namespace Yna.Editor
{
    partial class SceneSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fogStart = new System.Windows.Forms.TextBox();
            this.fogEnd = new System.Windows.Forms.TextBox();
            this.fogEnabled = new System.Windows.Forms.CheckBox();
            this.pictureColor = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.skyboxLeft = new System.Windows.Forms.TextBox();
            this.skyboxRight = new System.Windows.Forms.TextBox();
            this.skyboxTop = new System.Windows.Forms.TextBox();
            this.skyboxBottom = new System.Windows.Forms.TextBox();
            this.skyboxFront = new System.Windows.Forms.TextBox();
            this.skyboxBack = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fog";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.fogStart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fogEnd, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.fogEnabled, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureColor, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fog Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fog End";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fog Color";
            // 
            // fogStart
            // 
            this.fogStart.Location = new System.Drawing.Point(109, 27);
            this.fogStart.Name = "fogStart";
            this.fogStart.Size = new System.Drawing.Size(100, 20);
            this.fogStart.TabIndex = 5;
            this.fogStart.Text = "10";
            // 
            // fogEnd
            // 
            this.fogEnd.Location = new System.Drawing.Point(109, 51);
            this.fogEnd.Name = "fogEnd";
            this.fogEnd.Size = new System.Drawing.Size(100, 20);
            this.fogEnd.TabIndex = 6;
            this.fogEnd.Text = "600";
            // 
            // fogEnabled
            // 
            this.fogEnabled.AutoSize = true;
            this.fogEnabled.Location = new System.Drawing.Point(6, 3);
            this.fogEnabled.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.fogEnabled.Name = "fogEnabled";
            this.fogEnabled.Size = new System.Drawing.Size(91, 17);
            this.fogEnabled.TabIndex = 7;
            this.fogEnabled.Text = "Fog enabled?";
            this.fogEnabled.UseVisualStyleBackColor = true;
            // 
            // pictureColor
            // 
            this.pictureColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureColor.Location = new System.Drawing.Point(109, 81);
            this.pictureColor.Name = "pictureColor";
            this.pictureColor.Size = new System.Drawing.Size(100, 22);
            this.pictureColor.TabIndex = 8;
            this.pictureColor.TabStop = false;
            this.pictureColor.Click += new System.EventHandler(this.pictureColor_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(182, 386);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(101, 386);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backgroundPath);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background";
            // 
            // backgroundPath
            // 
            this.backgroundPath.Location = new System.Drawing.Point(12, 20);
            this.backgroundPath.Name = "backgroundPath";
            this.backgroundPath.Size = new System.Drawing.Size(227, 20);
            this.backgroundPath.TabIndex = 1;
            this.backgroundPath.Click += new System.EventHandler(this.backgroundPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(6, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 173);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skybox";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.skyboxLeft, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.skyboxRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.skyboxTop, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.skyboxBottom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.skyboxFront, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.skyboxBack, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bottom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Front";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Back";
            // 
            // skyboxLeft
            // 
            this.skyboxLeft.Location = new System.Drawing.Point(74, 3);
            this.skyboxLeft.Name = "skyboxLeft";
            this.skyboxLeft.Size = new System.Drawing.Size(162, 20);
            this.skyboxLeft.TabIndex = 6;
            this.skyboxLeft.Tag = "Left";
            this.skyboxLeft.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // skyboxRight
            // 
            this.skyboxRight.Location = new System.Drawing.Point(74, 27);
            this.skyboxRight.Name = "skyboxRight";
            this.skyboxRight.Size = new System.Drawing.Size(162, 20);
            this.skyboxRight.TabIndex = 7;
            this.skyboxRight.Tag = "Right";
            this.skyboxRight.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // skyboxTop
            // 
            this.skyboxTop.Location = new System.Drawing.Point(74, 51);
            this.skyboxTop.Name = "skyboxTop";
            this.skyboxTop.Size = new System.Drawing.Size(162, 20);
            this.skyboxTop.TabIndex = 8;
            this.skyboxTop.Tag = "Top";
            this.skyboxTop.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // skyboxBottom
            // 
            this.skyboxBottom.Location = new System.Drawing.Point(74, 75);
            this.skyboxBottom.Name = "skyboxBottom";
            this.skyboxBottom.Size = new System.Drawing.Size(162, 20);
            this.skyboxBottom.TabIndex = 9;
            this.skyboxBottom.Tag = "Bottom";
            this.skyboxBottom.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // skyboxFront
            // 
            this.skyboxFront.Location = new System.Drawing.Point(74, 99);
            this.skyboxFront.Name = "skyboxFront";
            this.skyboxFront.Size = new System.Drawing.Size(162, 20);
            this.skyboxFront.TabIndex = 10;
            this.skyboxFront.Tag = "Front";
            this.skyboxFront.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // skyboxBack
            // 
            this.skyboxBack.Location = new System.Drawing.Point(74, 123);
            this.skyboxBack.Name = "skyboxBack";
            this.skyboxBack.Size = new System.Drawing.Size(162, 20);
            this.skyboxBack.TabIndex = 11;
            this.skyboxBack.Tag = "Back";
            this.skyboxBack.Click += new System.EventHandler(this.skyboxInputLoadTexture_Click);
            // 
            // SceneSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SceneSettingsForm";
            this.Text = "Scene settings";
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fogStart;
        private System.Windows.Forms.TextBox fogEnd;
        private System.Windows.Forms.CheckBox fogEnabled;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.PictureBox pictureColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox backgroundPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox skyboxLeft;
        private System.Windows.Forms.TextBox skyboxRight;
        private System.Windows.Forms.TextBox skyboxTop;
        private System.Windows.Forms.TextBox skyboxBottom;
        private System.Windows.Forms.TextBox skyboxFront;
        private System.Windows.Forms.TextBox skyboxBack;
    }
}