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
        public event EventHandler<TransformChangedEventArgs> TransformPropertyChanged = null;

        private void OnPropertyChanged(string property, string axis, float value)
        {
            if (TransformPropertyChanged != null)
                TransformPropertyChanged(this, new TransformChangedEventArgs(property, axis, value));
        }

        public TransformControl()
        {
            InitializeComponent();
        }

        private void transformValueChanged(object sender, EventArgs e)
        {
            TextBox tr = sender as TextBox;
            string [] temp = tr.Name.Split(new char[] { '_' });
            string property = temp[1];
            string axis = temp[2];
            float value = float.Parse((sender as TextBox).Text);
            OnPropertyChanged(property, axis, value);
        }

        public void SetTransform(Vector2 position, float rotation, Vector2 scale)
        {
            transform_Position_X.Text = position.X.ToString();
            transform_Position_Y.Text = position.Y.ToString();
            transform_Position_Z.Text = "1".ToString();
            
            transform_Rotation_X.Text = "0".ToString();
            transform_Rotation_Y.Text = rotation.ToString();
            transform_Rotation_Z.Text = "0".ToString();

            transform_Scale_X.Text = scale.X.ToString();
            transform_Scale_Y.Text = scale.Y.ToString();
            transform_Scale_Z.Text = "1".ToString();

            transform_Position_Z.Enabled = false;
            transform_Rotation_X.Enabled = false;
            transform_Rotation_Z.Enabled = false;
            transform_Scale_Z.Enabled = false;
        }

        public void SetTransform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            transform_Position_X.Text = position.X.ToString();
            transform_Position_Y.Text = position.Y.ToString();
            transform_Position_Z.Text = position.Z.ToString();

            transform_Rotation_X.Text = rotation.X.ToString();
            transform_Rotation_Y.Text = rotation.Y.ToString();
            transform_Rotation_Z.Text = rotation.Z.ToString();

            transform_Scale_X.Text = scale.X.ToString();
            transform_Scale_Y.Text = scale.Y.ToString();
            transform_Scale_Z.Text = scale.Z.ToString();

            transform_Position_Z.Enabled = true;
            transform_Rotation_X.Enabled = true;
            transform_Rotation_Z.Enabled = true;
            transform_Scale_Z.Enabled = true;
        }
    }
}
