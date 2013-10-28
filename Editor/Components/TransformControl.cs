using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace Yna.Editor.Components
{
    public partial class TransformControl : UserControl
    {
        public event EventHandler<TransformChangedEventArgs> TransformChanged = null;
        private bool _locked;

        public TransformControl()
        {
            InitializeComponent();
            _locked = false;
        }

        private void transformValueChanged(object sender, EventArgs e)
        {
            if (!_locked)
            {
                Vector3 position = new Vector3(float.Parse(transform_Position_X.Text), float.Parse(transform_Position_Y.Text), float.Parse(transform_Position_Z.Text));
                Vector3 rotation = new Vector3(float.Parse(transform_Rotation_X.Text), float.Parse(transform_Rotation_Y.Text), float.Parse(transform_Rotation_Z.Text));
                Vector3 scale = new Vector3(float.Parse(transform_Scale_X.Text), float.Parse(transform_Scale_Y.Text), float.Parse(transform_Scale_Z.Text));

                if (TransformChanged != null)
                    TransformChanged(this, new TransformChangedEventArgs(position, rotation, scale));
            }
        }

        public void Setup(Vector3 position, Vector3 rotation, Vector3 scale, bool isTransform2D)
        {
            _locked = true;

            transform_Position_X.Text = position.X.ToString();
            transform_Position_Y.Text = position.Y.ToString();
            transform_Position_Z.Text = position.Z.ToString();

            transform_Rotation_X.Text = rotation.X.ToString();
            transform_Rotation_Y.Text = rotation.Y.ToString();
            transform_Rotation_Z.Text = rotation.Z.ToString();

            transform_Scale_X.Text = scale.X.ToString();
            transform_Scale_Y.Text = scale.Y.ToString();
            transform_Scale_Z.Text = scale.Z.ToString();

            transform_Position_Z.Enabled = !isTransform2D;
            transform_Rotation_X.Enabled = !isTransform2D;
            transform_Rotation_Z.Enabled = !isTransform2D;
            transform_Scale_Z.Enabled = !isTransform2D;

            _locked = false;
        }
    }
}
