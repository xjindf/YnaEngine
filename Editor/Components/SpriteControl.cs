using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Yna.Editor.Components
{
    public partial class SpriteControl : UserControl
    {
        private float _spriteOrder;
        private Color _spriteColor;
        private OpenFileDialog openFileDialogImage;
        private ColorDialog colorDialog;
        private bool _locked;

        #region Events

        public event EventHandler<PropertyChangedEventArgs<string>> TextureChanged = null;
        public event EventHandler<PropertyChangedEventArgs<int>> OriginChanged = null;
        public event EventHandler<PropertyChangedEventArgs<Color>> ColorChanged = null;
        public event EventHandler<PropertyChangedEventArgs<float>> OrderChanged = null;

        #endregion

        #region Fields

        private float SpriteOrder
        {
            get { return _spriteOrder; }
            set
            {
                _spriteOrder = value;
                textOrder.Text = _spriteOrder.ToString();
            }
        }

        private Color SpriteColor
        {
            get { return _spriteColor; }
            set
            {
                _spriteColor = value;
                pictureColor.BackColor = value;
            }
        }

        #endregion

        public SpriteControl()
        {
            InitializeComponent();
            _locked = false;
        }

        public void Setup(string texture, int origin, Color color, float order)
        {
            _locked = true;

            texturePath.Text = texture;
            comboOrigin.SelectedIndex = (origin < comboOrigin.Items.Count) ? origin : 0;
            SpriteOrder = order;
            SpriteColor = color;

            _locked = false;
        }

        #region Event handlers

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (!_locked)
            {
                if (openFileDialogImage == null)
                {
                    openFileDialogImage = new OpenFileDialog();
                    openFileDialogImage.Filter = "Jpeg (*.jpg)|*.jpg|Jpeg (*.png)|*.png|All files (*.*)|*.*";
                    openFileDialogImage.Title = "Please select an image file to load";
                    openFileDialogImage.RestoreDirectory = true;
                    openFileDialogImage.Multiselect = false;
                    openFileDialogImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
                }

                if (openFileDialogImage.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialogImage.FileName != String.Empty)
                    {
                        texturePath.Text = openFileDialogImage.FileName;

                        if (TextureChanged != null)
                            TextureChanged(this, new PropertyChangedEventArgs<string>(texturePath.Text));
                    }
                    else
                        MessageBox.Show("Invalid image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (!_locked)
            {
                string[] temp = (sender as Button).Name.Split(new char[] { '_' });

                if (temp[1] == "Min")
                    SpriteOrder--;
                else
                    SpriteOrder++;

                if (OrderChanged != null)
                    OrderChanged(this, new PropertyChangedEventArgs<float>(SpriteOrder));
            }
        }

        private void pictureColor_Click(object sender, EventArgs e)
        {
            if (!_locked)
            {
                if (colorDialog == null)
                    colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                    SpriteColor = colorDialog.Color;
            }
        }

        private void pictureColor_BackColorChanged(object sender, EventArgs e)
        {
            if (!_locked && ColorChanged != null)
                ColorChanged(this, new PropertyChangedEventArgs<Color>(pictureColor.BackColor));
        }

        private void comboOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_locked && OriginChanged != null)
                OriginChanged(this, new PropertyChangedEventArgs<int>(comboOrigin.SelectedIndex));
        }

        #endregion
    }
}
