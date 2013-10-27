using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yna.Editor
{
    using Microsoft.Xna.Framework.Graphics;
    using System.IO;
    using System.Threading;
    using Yna.Editor.Components;
    using Yna.Engine;
    using Yna.Engine.Graphics2D;
    using Yna.Engine.Graphics2D.Particle;
    using Yna.Engine.Graphics3D;
    using Yna.Engine.Graphics3D.Geometry;
    using Yna.Engine.Graphics3D.Terrain;
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;
    using XnaVector2 = Microsoft.Xna.Framework.Vector2;
    using XnaVector3 = Microsoft.Xna.Framework.Vector3;
    using XnaMathHelper = Microsoft.Xna.Framework.MathHelper;

    public enum EditorMode
    {
        Add = 0, Move, Rotate, Scale, Edit, Remove
    }

    public partial class MainEditorForm : Form
    {
        private Thread _splashThread;
        private bool _autoUpdateScene;
        private string _typeToAdd;
        private TreeNode _rootSceneNode;
        private TreeNode _currentSceneNode;
        private SceneSettingsForm _settingsForm;
        private GameObject _currentGameObject;
        private SceneSettings _sceneSettings;

        // EditorGameControl glGameControl;

        public bool AutoUpdateScene
        {
            get { return _autoUpdateScene; }
            set
            {
                if (value != _autoUpdateScene)
                {
                    if (_autoUpdateScene)
                        Application.Idle += UpdateGLControl;
                    else
                        Application.Idle -= UpdateGLControl;
                }
                _autoUpdateScene = value;
            }
        }

        public MainEditorForm()
        {
            _splashThread = new Thread(new ThreadStart(OnSplashThread));
            _splashThread.Start();

            InitializeComponent();
            _autoUpdateScene = true;

            _rootSceneNode = new TreeNode("Scene");
            sceneTreeView.Nodes.Add(_rootSceneNode);
            sceneTreeView.NodeMouseClick += sceneTreeView_NodeMouseClick;
            _currentSceneNode = _rootSceneNode;

            foreach (ToolStripItem item in menuItem_GameObject.DropDownItems)
                item.Click += gameObjectMenuItem_Click;

            _typeToAdd = String.Empty;
            _sceneSettings = new SceneSettings();

            YnText.DefaultColor = XnaColor.White;
        }

        private void MainEditor_Load(object sender, EventArgs evt)
        {
            Application.Idle += UpdateGLControl;
            glGameControl.Click += glGameControl_Click;
            glGameControl.GameObjectClicked += glGameControl_GameObjectClicked;
            glGameControl.MouseMove += glGameControl_MouseMove;

            _splashThread.Abort();

            transformControl1.TransformChanged += transformControl1_TransformPropertyChanged;
            textControl1.TextChanged += textControl1_TextChanged;
            spriteControl1.TextureChanged += spriteControl1_TextureChanged;
            spriteControl1.ColorChanged += spriteControl1_ColorChanged;
            spriteControl1.OriginChanged += spriteControl1_OriginChanged;
            spriteControl1.OrderChanged += spriteControl1_OrderChanged;
        }

        private void AddGameObject(string type, string subType)
        {
            // 2D
            if (type == "Sprite")
            {
                YnEntity gameObject = null;
                switch (subType)
                {
                    case "Sprite": gameObject = new YnSprite("images/default_sprite"); break;
                    case "Particles":
                        gameObject = new YnEmitter(new XnaVector2(YnScreen.Width / 2, YnScreen.Height / 2), XnaVector2.UnitY, XnaMathHelper.PiOver4, 150);
                        break;
                    case "Text": gameObject = new YnText("font/default", "Hello World"); break;
                }

                if (gameObject == null)
                    gameObject = new YnGroup(); // Fix that

                glGameControl.AddGameObject(gameObject);
            }
            else if (type == "Geometry")
            {
                YnEntity3D gameObject = null;
                BaseGeometry<VertexPositionNormalTexture> geometry = null;

                switch (subType)
                {
                    case "Cube": geometry = new CubeGeometry(); break;
                    case "Cylinder": new CylinderGeometry(new XnaVector3(0, 10, 0), new XnaVector3(0, 0, 0), 5, 5, false, 10, 10, XnaVector3.One); break;
                    case "IcoSphere": new IcoSphereGeometry(32, 4, false); break;
                    case "Plane": new PlaneGeometry(new XnaVector3(10)); break;
                    case "Pyramid": new PyramidGeometry(new XnaVector3(10)); break;
                    case "Sphere": new SphereGeometry(10); break;
                    case "Torus": new TorusGeometry(6, 1, false, 5, 15, XnaVector3.One, XnaVector3.Zero); break;
                }

                if (geometry != null)
                    gameObject = new YnMeshGeometry(geometry, "images/default_geometry");
                else
                    gameObject = new YnGroup3D(null); // TODO fix that

                glGameControl.AddGameObject(gameObject);
            }
            else if (type == "Terrain")
            {
                BaseTerrain terrain = null;
                if (subType == "Simple")
                    terrain = new SimpleTerrain("images/terrain_map", 500, 500, 10, 10);
                else
                    terrain = new Heightmap("images/terrain_heightfield", "images/terrain_map", new XnaVector3(500, 500, 500));

                glGameControl.AddGameObject(terrain);
            }

            AddSceneNode(subType);
        }

        public void AddSceneNode(string type)
        {
            TreeNode node = new TreeNode(type);
            _currentSceneNode.Nodes.Add(node);
        }

        private void OnSplashThread()
        {
            SplashScreen sp = new SplashScreen();
            sp.ShowDialog();
        }

        #region Inspector handlers

        private void textControl1_TextChanged(object sender, PropertyChangedEventArgs<string> e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnText)
                {
                    YnText goText = _currentGameObject as YnText;
                    goText.Text = e.Value;
                }
            }
        }

        private void transformControl1_TransformPropertyChanged(object sender, TransformChangedEventArgs e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnEntity)
                {
                    YnEntity go = _currentGameObject as YnEntity;

                    go.X = (int)e.Transform[0].X;
                    go.Y = (int)e.Transform[0].Y;
                    go.Rotation = e.Transform[1].Y;
                    go.Scale = new XnaVector2(e.Transform[2].X, e.Transform[2].Y);
                }
                else if (_currentGameObject is YnEntity3D)
                {
                    YnEntity3D go3 = _currentGameObject as YnEntity3D;
                    go3.Position = e.Transform[0];
                    go3.Rotation = e.Transform[1];
                    go3.Scale = e.Transform[2];
                }
            }
        }

        private void sceneTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = sender as TreeNode;
            if (node != null)
            {
                if (node.Nodes.Count > 0)
                    _currentSceneNode = node;
            }
        }

        #endregion

        #region Inspector - Sprite handlers

        private void spriteControl1_TextureChanged(object sender, PropertyChangedEventArgs<string> e)
        {
            if (_currentGameObject != null)
            {
                Texture2D texture = Texture2D.FromStream(YnG.GraphicsDevice, new FileStream(e.Value, FileMode.Open));

                if (texture != null)
                {
                    YnEntity gameObject = _currentGameObject as YnEntity;
                    gameObject.Texture = texture;
                    gameObject.ReloadTexture();
                }
            }
        }

        private void spriteControl1_OrderChanged(object sender, PropertyChangedEventArgs<float> e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnEntity)
                {
                    YnEntity go = _currentGameObject as YnEntity;
                    go.LayerDepth = e.Value;
                }
            }
        }

        private void spriteControl1_OriginChanged(object sender, PropertyChangedEventArgs<int> e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnEntity)
                {
                    YnEntity go = _currentGameObject as YnEntity;
                    go.SetOrigin((ObjectOrigin)e.Value);
                }
            }
        }

        private void spriteControl1_ColorChanged(object sender, PropertyChangedEventArgs<GdiColor> e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnEntity)
                {
                    YnEntity go = _currentGameObject as YnEntity;
                    go.Color = new XnaColor(e.Value.R, e.Value.G, e.Value.B, e.Value.A);
                }
            }
        }

        #endregion

        #region Menu handlers

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YnaEngine Editor is designed to build 2D or 3D scene for use it in YnaEngine.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void renderMenuItem_Click(object sender, EventArgs e)
        {
            if (_settingsForm == null)
                _settingsForm = new SceneSettingsForm();

            _settingsForm.SceneSettings = _sceneSettings;
            _settingsForm.ShowDialog();
        }

        private void gameObjectMenuItem_Click(object sender, EventArgs e)
        {
            string[] temp = (sender as ToolStripItem).Name.Split(new char[] { '_' });
            string type = temp[1];
            string subType = temp[2];

            AddGameObject(type, subType);
        }

        #endregion

        #region GLGameControl handlers

        private void glGameControl_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            if (me.Button == System.Windows.Forms.MouseButtons.Right)
                _currentGameObject = null;
            else
                glGameControl.CheckMouseClick(me.X, me.Y);
        }

        private void glGameControl_GameObjectClicked(object sender, GameObjectClickedEventArgs e)
        {
            _currentGameObject = e.GameObject;

            if (_currentGameObject is YnEntity)
            {
                YnEntity go = _currentGameObject as YnEntity;
                transformControl1.Setup(new XnaVector3(go.X, go.Y, 1), new XnaVector3(0, go.Rotation, 0), new XnaVector3(go.Scale.X, go.Scale.Y, 1), true);

                if (go is YnText)
                {
                    YnText text = go as YnText;
                    textControl1.Setup(text.Text);
                }

                if (go.Texture != null)
                    spriteControl1.Setup(go.Texture.Name, 0, XnaColorToGDI(go.Color), go.LayerDepth);
            }
            else if (_currentGameObject is YnEntity3D)
            {
                YnEntity3D go = _currentGameObject as YnEntity3D;
                transformControl1.Setup(go.Position, go.Rotation, go.Scale, false);
            }
        }

        void glGameControl_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            if (_currentGameObject != null)
            {

                if (me.Button == System.Windows.Forms.MouseButtons.Left)
                    glGameControl.MoveGameObject(_currentGameObject, me.X, me.Y);
            }
            else if (_currentGameObject == null && me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                GameObject[] gos = glGameControl.CheckMouseClick(me.X, me.Y, true);

                if (gos.Length > 0)
                    glGameControl.MoveGameObject(gos[0], me.X, me.Y);
            }
        }

        private void UpdateGLControl(object sender, EventArgs e)
        {
            glGameControl.Invalidate();
        }

        #endregion

        private Color XnaColorToGDI(XnaColor xnaColor)
        {
            return Color.FromArgb(xnaColor.A, xnaColor.R, xnaColor.G, xnaColor.B);
        }
    }
}
