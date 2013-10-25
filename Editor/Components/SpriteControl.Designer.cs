namespace Yna.Editor.Components
{
    partial class SpriteControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.texturePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texturePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.isEnabled);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite";
            // 
            // isEnabled
            // 
            this.isEnabled.AutoSize = true;
            this.isEnabled.Checked = true;
            this.isEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isEnabled.Location = new System.Drawing.Point(6, 16);
            this.isEnabled.Name = "isEnabled";
            this.isEnabled.Size = new System.Drawing.Size(65, 17);
            this.isEnabled.TabIndex = 0;
            this.isEnabled.Text = "Enabled";
            this.isEnabled.UseVisualStyleBackColor = true;
            this.isEnabled.CheckedChanged += new System.EventHandler(this.isEnabled_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texture";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(131, 39);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // texturePath
            // 
            this.texturePath.Location = new System.Drawing.Point(58, 40);
            this.texturePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.texturePath.Name = "texturePath";
            this.texturePath.Size = new System.Drawing.Size(60, 20);
            this.texturePath.TabIndex = 3;
            // 
            // SpriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SpriteControl";
            this.Size = new System.Drawing.Size(215, 86);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isEnabled;
        private System.Windows.Forms.TextBox texturePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
    }
}
