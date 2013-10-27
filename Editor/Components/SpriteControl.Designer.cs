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
            this.comboOrigin = new System.Windows.Forms.ComboBox();
            this.textOrder = new System.Windows.Forms.TextBox();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Min = new System.Windows.Forms.Button();
            this.pictureColor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texturePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboOrigin);
            this.groupBox1.Controls.Add(this.textOrder);
            this.groupBox1.Controls.Add(this.button_Plus);
            this.groupBox1.Controls.Add(this.button_Min);
            this.groupBox1.Controls.Add(this.pictureColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.texturePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite";
            // 
            // comboOrigin
            // 
            this.comboOrigin.FormattingEnabled = true;
            this.comboOrigin.Items.AddRange(new object[] {
            "TopLeft",
            "Top",
            "TopRight",
            "Left",
            "Center",
            "Right",
            "BottomLeft",
            "Bottom",
            "BottomRight"});
            this.comboOrigin.Location = new System.Drawing.Point(55, 48);
            this.comboOrigin.Name = "comboOrigin";
            this.comboOrigin.Size = new System.Drawing.Size(148, 21);
            this.comboOrigin.TabIndex = 13;
            this.comboOrigin.SelectedIndexChanged += new System.EventHandler(this.comboOrigin_SelectedIndexChanged);
            // 
            // textOrder
            // 
            this.textOrder.Location = new System.Drawing.Point(89, 104);
            this.textOrder.Name = "textOrder";
            this.textOrder.Size = new System.Drawing.Size(64, 20);
            this.textOrder.TabIndex = 12;
            this.textOrder.Text = "1";
            this.textOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(168, 104);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(20, 20);
            this.button_Plus.TabIndex = 11;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // button_Min
            // 
            this.button_Min.Location = new System.Drawing.Point(55, 104);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(20, 20);
            this.button_Min.TabIndex = 10;
            this.button_Min.Text = "-";
            this.button_Min.UseVisualStyleBackColor = true;
            this.button_Min.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // pictureColor
            // 
            this.pictureColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureColor.Location = new System.Drawing.Point(55, 80);
            this.pictureColor.Name = "pictureColor";
            this.pictureColor.Size = new System.Drawing.Size(148, 13);
            this.pictureColor.TabIndex = 9;
            this.pictureColor.TabStop = false;
            this.pictureColor.BackColorChanged += new System.EventHandler(this.pictureColor_BackColorChanged);
            this.pictureColor.Click += new System.EventHandler(this.pictureColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origin";
            // 
            // texturePath
            // 
            this.texturePath.Location = new System.Drawing.Point(55, 20);
            this.texturePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.texturePath.Name = "texturePath";
            this.texturePath.Size = new System.Drawing.Size(98, 20);
            this.texturePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texture";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(159, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(44, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // SpriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SpriteControl";
            this.Size = new System.Drawing.Size(215, 134);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texturePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboOrigin;
        private System.Windows.Forms.TextBox textOrder;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Min;
    }
}
