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
        public event EventHandler<StringChangedEventArgs> TextureChanged = null;
        public event EventHandler<EnabledChangedEventArgs> EnabledChanged = null;

        private OpenFileDialog openFileDialogImage;

        public SpriteControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage == null)
            {
                openFileDialogImage = new OpenFileDialog();
                openFileDialogImage.RestoreDirectory = true;
                openFileDialogImage.Multiselect = false;
                openFileDialogImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            }

            var result = openFileDialogImage.OpenFile();

            if (openFileDialogImage.FileName != String.Empty)
            {
                texturePath.Text = openFileDialogImage.FileName;

                if (TextureChanged != null)
                    TextureChanged(this, new StringChangedEventArgs(texturePath.Text));
            }
        }

        private void isEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (EnabledChanged != null)
                EnabledChanged(this, new EnabledChangedEventArgs(isEnabled.Checked));
        }

        public void SetTexture(string texture)
        {
            texturePath.Text = texture;
        }
    }
}
