using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yna.Engine;

namespace Yna.Editor
{
    using Yna.Engine.Scene;
    using XnaColor = Microsoft.Xna.Framework.Color;

    public partial class SceneSettingsForm : Form
    {
        private SceneSettings sceneSettings;
        private OpenFileDialog openFileDialogImage;
        private ColorDialog colorDialog;

        public SceneSettings SceneSettings
        {
            get { return sceneSettings; }
            set { sceneSettings = value; }
        }

        public SceneSettingsForm()
        {
            InitializeComponent();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            fogEnabled.Checked = false;
            fogStart.Text = "10";
            fogEnd.Text = "600";
            pictureColor.BackColor = Color.Black;

            skyboxBack.Text = "";
            skyboxBottom.Text = "";
            skyboxFront.Text = "";
            skyboxLeft.Text = "";
            skyboxRight.Text = "";
            skyboxTop.Text = "";

            backgroundPath.Text = "";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            sceneSettings.FogEnabled = fogEnabled.Checked;
            sceneSettings.FogColor = new XnaColor(pictureColor.BackColor.R, pictureColor.BackColor.G, pictureColor.BackColor.B, pictureColor.BackColor.A);
            sceneSettings.FogStart = float.Parse(fogStart.Text);
            sceneSettings.FogEnd = float.Parse(fogEnd.Text);

            string[] skybox = new string[6];
            skybox[0] = skyboxLeft.Text;
            skybox[1] = skyboxRight.Text;
            skybox[2] = skyboxTop.Text;
            skybox[3] = skyboxBottom.Text;
            skybox[4] = skyboxFront.Text;
            skybox[5] = skyboxBack.Text;

            bool isValidSkybox = false;
            int i = 0;

            while (i < 6 && !isValidSkybox)
                isValidSkybox = (skybox[i] == String.Empty) ? false : isValidSkybox;

            if (isValidSkybox)
                sceneSettings.Skybox = skybox;
            else
                sceneSettings.BackgroundTexture = backgroundPath.Text;
        }

        private void skyboxInputLoadTexture_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                switch (textBox.Tag.ToString())
                {
                    case "Back": skyboxBack.Text = OpenFileDialogImage(); break;
                    case "Bottom": skyboxBottom.Text = OpenFileDialogImage(); break;
                    case "Front": skyboxFront.Text = OpenFileDialogImage(); break;
                    case "Left": skyboxLeft.Text = OpenFileDialogImage(); break;
                    case "Right": skyboxRight.Text = OpenFileDialogImage(); break;
                    case "Top": skyboxTop.Text = OpenFileDialogImage(); break;
                }
            }
        }

        private void pictureColor_Click(object sender, EventArgs e)
        {
            if (colorDialog == null)
                colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureColor.BackColor = colorDialog.Color;
        }

        private void backgroundPath_Click(object sender, EventArgs e)
        {
            backgroundPath.Text = OpenFileDialogImage();
        }

        private string OpenFileDialogImage()
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
                    return openFileDialogImage.FileName;
                }
                else
                    MessageBox.Show("Invalid image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return string.Empty;
        }
    }
}
