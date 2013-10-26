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
    using Yna.Engine;
    using Yna.Engine.Graphics2D;
    using Yna.Engine.Graphics3D;
    using Yna.Engine.Graphics3D.Geometry;
    using Yna.Engine.Graphics3D.Terrain;
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;
    using XnaVector2 = Microsoft.Xna.Framework.Vector2;
    using XnaVector3 = Microsoft.Xna.Framework.Vector3;

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
        private RenderSettingsForm _settingsForm;
        private GameObject _currentGameObject;

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

            YnText.DefaultColor = XnaColor.White;
        }

        private void MainEditor_Load(object sender, EventArgs evt)
        {
            Application.Idle += UpdateGLControl;
            glGameControl.Click += glGameControl_Click;
            glGameControl.GameObjectClicked += glGameControl_GameObjectClicked;
            glGameControl.MouseMove += glGameControl_MouseMove;

            _splashThread.Abort();

            transformControl1.TransformPropertyChanged += transformControl1_TransformPropertyChanged;
            textControl1.TextChanged += textControl1_TextChanged;
            spriteControl1.TextureChanged += spriteControl1_TextureChanged;
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
                    case "Particles": break;
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

        private void spriteControl1_TextureChanged(object sender, Components.StringChangedEventArgs e)
        {
            if (_currentGameObject != null)
            {
                Texture2D texture = Texture2D.FromStream(YnG.GraphicsDevice, new FileStream(e.Text, FileMode.Open));

                if (texture != null)
                {
                    YnEntity gameObject = _currentGameObject as YnEntity;
                    gameObject.Texture = texture;
                    gameObject.ReloadTexture();
                }
            }
        }

        private void textControl1_TextChanged(object sender, Components.StringChangedEventArgs e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnText)
                {
                    YnText goText = _currentGameObject as YnText;
                    goText.Text = e.Text;
                }
            }
        }

        private void transformControl1_TransformPropertyChanged(object sender, Components.TransformChangedEventArgs e)
        {
            if (_currentGameObject != null)
            {
                if (_currentGameObject is YnEntity)
                {
                    YnEntity go = _currentGameObject as YnEntity;
                        
                    if (e.Property == "Position")
                    {
                        switch (e.Axis)
                        {
                            case "X": go.X = (int)e.Value; break;
                            case "Y": go.Y = (int)e.Value; break;
                        }
                    }
                    else if (e.Property == "Rotation")
                    {
                        go.Rotation = e.Value;
                    }
                    else if (e.Property == "Scale")
                    {
                        switch (e.Axis)
                        {
                            case "X": go.Scale = new XnaVector2(e.Value, go.Scale.Y); break;
                            case "Y": go.Scale = new XnaVector2(go.Scale.X, e.Value); break;
                        }
                    }
                }
                else if (_currentGameObject is YnEntity3D)
                {
                    YnEntity3D go3 = _currentGameObject as YnEntity3D;

                    if (e.Property == "Position")
                    {
                        switch (e.Axis)
                        {
                            case "X": go3.X = e.Value; break;
                            case "Y": go3.Y = e.Value; break;
                            case "Z": go3.Z = e.Value; break;
                        }
                    }
                    else if (e.Property == "Rotation")
                    {
                        switch (e.Axis)
                        {
                            case "X": go3.Rotation = new XnaVector3(e.Value, go3.Rotation.Y, go3.Rotation.Z); break;
                            case "Y": go3.Rotation = new XnaVector3(go3.Rotation.X, e.Value, go3.Rotation.Z); break;
                            case "Z": go3.Rotation = new XnaVector3(go3.Rotation.X, go3.Rotation.Y, e.Value); break;
                        }
                    }
                    else if (e.Property == "Scale")
                    {
                        switch (e.Axis)
                        {
                            case "X": go3.Scale = new XnaVector3(e.Value, go3.Scale.Y, go3.Scale.Z); break;
                            case "Y": go3.Scale = new XnaVector3(go3.Scale.X, e.Value, go3.Scale.Z); break;
                            case "Z": go3.Scale = new XnaVector3(go3.Scale.X, go3.Scale.Y, e.Value); break;
                        }
                    }
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
                _settingsForm = new RenderSettingsForm();

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

            glGameControl.CheckMouseClick(me.X, me.Y);
        }

        private void glGameControl_GameObjectClicked(object sender, GameObjectClickedEventArgs e)
        {
            _currentGameObject = e.GameObject;

            if (_currentGameObject is YnEntity)
            {
                YnEntity go = _currentGameObject as YnEntity;
                transformControl1.SetTransform(go.Position, go.Rotation, go.Scale);

                if (go is YnText)
                {
                    YnText text = go as YnText;
                    textControl1.SetText(text.Text);
                }

                if (go.Texture != null)
                    spriteControl1.SetTexture(go.Texture.Name);
            }
            else if (_currentGameObject is YnEntity3D)
            {
                YnEntity3D go = _currentGameObject as YnEntity3D;
                transformControl1.SetTransform(go.Position, go.Rotation, go.Scale);
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
                GameObject [] gos = glGameControl.CheckMouseClick(me.X, me.Y, true);

                foreach (GameObject go in gos)
                    glGameControl.MoveGameObject(go, me.X, me.Y);
            }
        }

        private void UpdateGLControl(object sender, EventArgs e)
        {
            glGameControl.Invalidate();
        }

        #endregion
    }
}
