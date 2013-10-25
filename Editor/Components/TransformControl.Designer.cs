namespace Yna.Editor.Components
{
    partial class TransformControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transform_Position_X = new System.Windows.Forms.TextBox();
            this.transform_Position_Y = new System.Windows.Forms.TextBox();
            this.transform_Position_Z = new System.Windows.Forms.TextBox();
            this.transform_Rotation_X = new System.Windows.Forms.TextBox();
            this.transform_Rotation_Y = new System.Windows.Forms.TextBox();
            this.transform_Rotation_Z = new System.Windows.Forms.TextBox();
            this.transform_Scale_X = new System.Windows.Forms.TextBox();
            this.transform_Scale_Y = new System.Windows.Forms.TextBox();
            this.transform_Scale_Z = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.06024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.93976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.transform_Position_X, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.transform_Position_Y, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.transform_Position_Z, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.transform_Rotation_X, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.transform_Rotation_Y, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.transform_Rotation_Z, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.transform_Scale_X, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.transform_Scale_Y, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.transform_Scale_Z, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scale";
            // 
            // transform_Position_X
            // 
            this.transform_Position_X.Location = new System.Drawing.Point(77, 3);
            this.transform_Position_X.Name = "transform_Position_X";
            this.transform_Position_X.Size = new System.Drawing.Size(30, 20);
            this.transform_Position_X.TabIndex = 3;
            this.transform_Position_X.Text = "0";
            this.transform_Position_X.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Position_Y
            // 
            this.transform_Position_Y.Location = new System.Drawing.Point(116, 3);
            this.transform_Position_Y.Name = "transform_Position_Y";
            this.transform_Position_Y.Size = new System.Drawing.Size(30, 20);
            this.transform_Position_Y.TabIndex = 4;
            this.transform_Position_Y.Text = "0";
            this.transform_Position_Y.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Position_Z
            // 
            this.transform_Position_Z.Location = new System.Drawing.Point(155, 3);
            this.transform_Position_Z.Name = "transform_Position_Z";
            this.transform_Position_Z.Size = new System.Drawing.Size(30, 20);
            this.transform_Position_Z.TabIndex = 5;
            this.transform_Position_Z.Text = "0";
            this.transform_Position_Z.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Rotation_X
            // 
            this.transform_Rotation_X.Location = new System.Drawing.Point(77, 27);
            this.transform_Rotation_X.Name = "transform_Rotation_X";
            this.transform_Rotation_X.Size = new System.Drawing.Size(30, 20);
            this.transform_Rotation_X.TabIndex = 6;
            this.transform_Rotation_X.Text = "0";
            this.transform_Rotation_X.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Rotation_Y
            // 
            this.transform_Rotation_Y.Location = new System.Drawing.Point(116, 27);
            this.transform_Rotation_Y.Name = "transform_Rotation_Y";
            this.transform_Rotation_Y.Size = new System.Drawing.Size(30, 20);
            this.transform_Rotation_Y.TabIndex = 7;
            this.transform_Rotation_Y.Text = "0";
            this.transform_Rotation_Y.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Rotation_Z
            // 
            this.transform_Rotation_Z.Location = new System.Drawing.Point(155, 27);
            this.transform_Rotation_Z.Name = "transform_Rotation_Z";
            this.transform_Rotation_Z.Size = new System.Drawing.Size(30, 20);
            this.transform_Rotation_Z.TabIndex = 8;
            this.transform_Rotation_Z.Text = "0";
            this.transform_Rotation_Z.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Scale_X
            // 
            this.transform_Scale_X.Location = new System.Drawing.Point(77, 51);
            this.transform_Scale_X.Name = "transform_Scale_X";
            this.transform_Scale_X.Size = new System.Drawing.Size(30, 20);
            this.transform_Scale_X.TabIndex = 9;
            this.transform_Scale_X.Text = "0";
            this.transform_Scale_X.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Scale_Y
            // 
            this.transform_Scale_Y.Location = new System.Drawing.Point(116, 51);
            this.transform_Scale_Y.Name = "transform_Scale_Y";
            this.transform_Scale_Y.Size = new System.Drawing.Size(30, 20);
            this.transform_Scale_Y.TabIndex = 10;
            this.transform_Scale_Y.Text = "0";
            this.transform_Scale_Y.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // transform_Scale_Z
            // 
            this.transform_Scale_Z.Location = new System.Drawing.Point(155, 51);
            this.transform_Scale_Z.Name = "transform_Scale_Z";
            this.transform_Scale_Z.Size = new System.Drawing.Size(30, 20);
            this.transform_Scale_Z.TabIndex = 11;
            this.transform_Scale_Z.Text = "0";
            this.transform_Scale_Z.TextChanged += new System.EventHandler(this.transformValueChanged);
            // 
            // TransformControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TransformControl";
            this.Size = new System.Drawing.Size(225, 109);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transform_Position_X;
        private System.Windows.Forms.TextBox transform_Position_Y;
        private System.Windows.Forms.TextBox transform_Position_Z;
        private System.Windows.Forms.TextBox transform_Rotation_X;
        private System.Windows.Forms.TextBox transform_Rotation_Y;
        private System.Windows.Forms.TextBox transform_Rotation_Z;
        private System.Windows.Forms.TextBox transform_Scale_X;
        private System.Windows.Forms.TextBox transform_Scale_Y;
        private System.Windows.Forms.TextBox transform_Scale_Z;

    }
}
