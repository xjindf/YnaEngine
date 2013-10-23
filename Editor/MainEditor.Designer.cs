using Yna.Engine;

namespace Yna.Editor
{
    partial class MainEditor
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ynEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ynGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ynParticleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ynSpriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ynTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scene2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scene2DGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scene3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.glGameControl = new Yna.Editor.EditorGameControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transformPositionX = new System.Windows.Forms.TextBox();
            this.transformPositionY = new System.Windows.Forms.TextBox();
            this.transformPositionZ = new System.Windows.Forms.TextBox();
            this.transformRotationX = new System.Windows.Forms.TextBox();
            this.transformRotationY = new System.Windows.Forms.TextBox();
            this.transformRotationZ = new System.Windows.Forms.TextBox();
            this.transformScaleX = new System.Windows.Forms.TextBox();
            this.transformScaleY = new System.Windows.Forms.TextBox();
            this.transformScaleZ = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sceneTreeView = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.assetsTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameObjectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.toolStripSeparator2,
            this.optionsMenuItem,
            this.toolStripSeparator3,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openMenuItem.Text = "Open";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveMenuItem.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsMenuItem.Text = "Options";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(113, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // gameObjectToolStripMenuItem
            // 
            this.gameObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameObjectToolStripMenuItem1,
            this.sceneToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            this.gameObjectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameObjectToolStripMenuItem.Text = "Scene";
            // 
            // gameObjectToolStripMenuItem1
            // 
            this.gameObjectToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ynEntityToolStripMenuItem,
            this.ynGroupToolStripMenuItem1,
            this.ynParticleToolStripMenuItem1,
            this.ynSpriteToolStripMenuItem1,
            this.ynTextToolStripMenuItem1,
            this.toolStripSeparator1});
            this.gameObjectToolStripMenuItem1.Name = "gameObjectToolStripMenuItem1";
            this.gameObjectToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.gameObjectToolStripMenuItem1.Text = "Game Object";
            // 
            // ynEntityToolStripMenuItem
            // 
            this.ynEntityToolStripMenuItem.Name = "ynEntityToolStripMenuItem";
            this.ynEntityToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ynEntityToolStripMenuItem.Text = "YnEntity";
            // 
            // ynGroupToolStripMenuItem1
            // 
            this.ynGroupToolStripMenuItem1.Name = "ynGroupToolStripMenuItem1";
            this.ynGroupToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.ynGroupToolStripMenuItem1.Text = "YnGroup";
            // 
            // ynParticleToolStripMenuItem1
            // 
            this.ynParticleToolStripMenuItem1.Name = "ynParticleToolStripMenuItem1";
            this.ynParticleToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.ynParticleToolStripMenuItem1.Text = "YnParticle";
            // 
            // ynSpriteToolStripMenuItem1
            // 
            this.ynSpriteToolStripMenuItem1.Name = "ynSpriteToolStripMenuItem1";
            this.ynSpriteToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.ynSpriteToolStripMenuItem1.Text = "YnSprite";
            // 
            // ynTextToolStripMenuItem1
            // 
            this.ynTextToolStripMenuItem1.Name = "ynTextToolStripMenuItem1";
            this.ynTextToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.ynTextToolStripMenuItem1.Text = "YnText";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // sceneToolStripMenuItem
            // 
            this.sceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scene2DToolStripMenuItem,
            this.scene2DGUIToolStripMenuItem,
            this.scene3DToolStripMenuItem});
            this.sceneToolStripMenuItem.Name = "sceneToolStripMenuItem";
            this.sceneToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sceneToolStripMenuItem.Text = "Scene";
            // 
            // scene2DToolStripMenuItem
            // 
            this.scene2DToolStripMenuItem.Name = "scene2DToolStripMenuItem";
            this.scene2DToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.scene2DToolStripMenuItem.Text = "Scene 2D";
            // 
            // scene2DGUIToolStripMenuItem
            // 
            this.scene2DGUIToolStripMenuItem.Name = "scene2DGUIToolStripMenuItem";
            this.scene2DGUIToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.scene2DGUIToolStripMenuItem.Text = "Scene 2D + GUI";
            // 
            // scene3DToolStripMenuItem
            // 
            this.scene3DToolStripMenuItem.Name = "scene3DToolStripMenuItem";
            this.scene3DToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.scene3DToolStripMenuItem.Text = "Scene 3D";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // renderingToolStripMenuItem
            // 
            this.renderingToolStripMenuItem.Name = "renderingToolStripMenuItem";
            this.renderingToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.renderingToolStripMenuItem.Text = "Rendering";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.glGameControl);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.splitContainer2);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 515);
            this.mainSplitContainer.SplitterDistance = 537;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // glGameControl
            // 
            this.glGameControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glGameControl.BackColor = System.Drawing.Color.Black;
            this.glGameControl.Location = new System.Drawing.Point(0, 0);
            this.glGameControl.Name = "glGameControl";
            this.glGameControl.Size = new System.Drawing.Size(538, 515);
            this.glGameControl.TabIndex = 0;
            this.glGameControl.VSync = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(243, 515);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.transformPositionX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.transformPositionY, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.transformPositionZ, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.transformRotationX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.transformRotationY, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.transformRotationZ, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.transformScaleX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.transformScaleY, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.transformScaleZ, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 73);
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
            // transformPositionX
            // 
            this.transformPositionX.Location = new System.Drawing.Point(61, 3);
            this.transformPositionX.Name = "transformPositionX";
            this.transformPositionX.Size = new System.Drawing.Size(52, 20);
            this.transformPositionX.TabIndex = 3;
            this.transformPositionX.Text = "0";
            // 
            // transformPositionY
            // 
            this.transformPositionY.Location = new System.Drawing.Point(119, 3);
            this.transformPositionY.Name = "transformPositionY";
            this.transformPositionY.Size = new System.Drawing.Size(46, 20);
            this.transformPositionY.TabIndex = 4;
            this.transformPositionY.Text = "0";
            // 
            // transformPositionZ
            // 
            this.transformPositionZ.Location = new System.Drawing.Point(171, 3);
            this.transformPositionZ.Name = "transformPositionZ";
            this.transformPositionZ.Size = new System.Drawing.Size(43, 20);
            this.transformPositionZ.TabIndex = 5;
            this.transformPositionZ.Text = "0";
            // 
            // transformRotationX
            // 
            this.transformRotationX.Location = new System.Drawing.Point(61, 27);
            this.transformRotationX.Name = "transformRotationX";
            this.transformRotationX.Size = new System.Drawing.Size(52, 20);
            this.transformRotationX.TabIndex = 6;
            this.transformRotationX.Text = "0";
            // 
            // transformRotationY
            // 
            this.transformRotationY.Location = new System.Drawing.Point(119, 27);
            this.transformRotationY.Name = "transformRotationY";
            this.transformRotationY.Size = new System.Drawing.Size(46, 20);
            this.transformRotationY.TabIndex = 7;
            this.transformRotationY.Text = "0";
            // 
            // transformRotationZ
            // 
            this.transformRotationZ.Location = new System.Drawing.Point(171, 27);
            this.transformRotationZ.Name = "transformRotationZ";
            this.transformRotationZ.Size = new System.Drawing.Size(43, 20);
            this.transformRotationZ.TabIndex = 8;
            this.transformRotationZ.Text = "0";
            // 
            // transformScaleX
            // 
            this.transformScaleX.Location = new System.Drawing.Point(61, 51);
            this.transformScaleX.Name = "transformScaleX";
            this.transformScaleX.Size = new System.Drawing.Size(52, 20);
            this.transformScaleX.TabIndex = 9;
            this.transformScaleX.Text = "0";
            // 
            // transformScaleY
            // 
            this.transformScaleY.Location = new System.Drawing.Point(119, 51);
            this.transformScaleY.Name = "transformScaleY";
            this.transformScaleY.Size = new System.Drawing.Size(46, 20);
            this.transformScaleY.TabIndex = 10;
            this.transformScaleY.Text = "0";
            // 
            // transformScaleZ
            // 
            this.transformScaleZ.Location = new System.Drawing.Point(171, 51);
            this.transformScaleZ.Name = "transformScaleZ";
            this.transformScaleZ.Size = new System.Drawing.Size(43, 20);
            this.transformScaleZ.TabIndex = 11;
            this.transformScaleZ.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(237, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sceneTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(229, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scene";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sceneTreeView
            // 
            this.sceneTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sceneTreeView.Location = new System.Drawing.Point(0, 3);
            this.sceneTreeView.Name = "sceneTreeView";
            this.sceneTreeView.Size = new System.Drawing.Size(229, 343);
            this.sceneTreeView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.assetsTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(229, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // assetsTreeView
            // 
            this.assetsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetsTreeView.Location = new System.Drawing.Point(7, 4);
            this.assetsTreeView.Name = "assetsTreeView";
            this.assetsTreeView.Size = new System.Drawing.Size(219, 345);
            this.assetsTreeView.TabIndex = 0;
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yna Engine Editor";
            this.Load += new System.EventHandler(this.MainEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameObjectToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transformPositionX;
        private System.Windows.Forms.TextBox transformPositionY;
        private System.Windows.Forms.TextBox transformPositionZ;
        private System.Windows.Forms.TextBox transformRotationX;
        private System.Windows.Forms.TextBox transformRotationY;
        private System.Windows.Forms.TextBox transformRotationZ;
        private System.Windows.Forms.TextBox transformScaleX;
        private System.Windows.Forms.TextBox transformScaleY;
        private System.Windows.Forms.TextBox transformScaleZ;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView sceneTreeView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView assetsTreeView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem gameObjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ynEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ynGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ynParticleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ynSpriteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ynTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scene2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scene2DGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scene3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderingToolStripMenuItem;
        private EditorGameControl glGameControl;
    }
}

