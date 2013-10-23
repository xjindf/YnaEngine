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
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;

    public partial class MainEditor : Form
    {
        private bool _autoUpdateScene;

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

        public MainEditor()
        {
            InitializeComponent();
            _autoUpdateScene = true;

            sceneTreeView.Controls.Add(new Label() { Text = "Scene 2D" });
        }

        void glGameControl_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

        }

        private void MainEditor_Load(object sender, EventArgs evt)
        {
            Application.Idle += UpdateGLControl;
            glGameControl.Click += glGameControl_Click;
        }

        private void UpdateGLControl(object sender, EventArgs e)
        {
            glGameControl.Invalidate();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YnaEngine Editor is designed to build 2D or 3D scene for use it in YnaEngine.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
