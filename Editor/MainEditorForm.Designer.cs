using Yna.Engine;

namespace Yna.Editor
{
    partial class MainEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditorForm));
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
            this.menuItem_GameObject = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Sprite_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Sprite_Particles = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Sprite_Sprite = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Sprite_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item_Geometry_Cube = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_Cylinder = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_IcoSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_Plane = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_Pyramid = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_Sphere = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Geometry_Torus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.item_Terrain_Simple = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Terrain_Heightmap = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.glGameControl = new Yna.Editor.EditorGameControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelGameObject = new System.Windows.Forms.FlowLayoutPanel();
            this.gameObjectControl1 = new Yna.Editor.Components.GameObjectControl();
            this.transformControl1 = new Yna.Editor.Components.TransformControl();
            this.spriteControl1 = new Yna.Editor.Components.SpriteControl();
            this.textControl1 = new Yna.Editor.Components.TextControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sceneTreeView = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.assetsTreeView = new System.Windows.Forms.TreeView();
            this.item_Geometry_Empty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelGameObject.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
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
            this.menuItem_GameObject,
            this.settingsToolStripMenuItem});
            this.gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            this.gameObjectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameObjectToolStripMenuItem.Text = "Scene";
            // 
            // menuItem_GameObject
            // 
            this.menuItem_GameObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Sprite_Group,
            this.item_Sprite_Particles,
            this.item_Sprite_Sprite,
            this.item_Sprite_Text,
            this.toolStripSeparator1,
            this.item_Geometry_Cube,
            this.item_Geometry_Cylinder,
            this.item_Geometry_IcoSphere,
            this.item_Geometry_Plane,
            this.item_Geometry_Pyramid,
            this.item_Geometry_Sphere,
            this.item_Geometry_Torus,
            this.toolStripSeparator4,
            this.item_Terrain_Simple,
            this.item_Terrain_Heightmap});
            this.menuItem_GameObject.Name = "menuItem_GameObject";
            this.menuItem_GameObject.Size = new System.Drawing.Size(152, 22);
            this.menuItem_GameObject.Text = "Add";
            // 
            // item_Sprite_Group
            // 
            this.item_Sprite_Group.Name = "item_Sprite_Group";
            this.item_Sprite_Group.Size = new System.Drawing.Size(178, 22);
            this.item_Sprite_Group.Text = "Empty";
            // 
            // item_Sprite_Particles
            // 
            this.item_Sprite_Particles.Name = "item_Sprite_Particles";
            this.item_Sprite_Particles.Size = new System.Drawing.Size(178, 22);
            this.item_Sprite_Particles.Text = "Particles";
            // 
            // item_Sprite_Sprite
            // 
            this.item_Sprite_Sprite.Name = "item_Sprite_Sprite";
            this.item_Sprite_Sprite.Size = new System.Drawing.Size(178, 22);
            this.item_Sprite_Sprite.Text = "Sprite";
            // 
            // item_Sprite_Text
            // 
            this.item_Sprite_Text.Name = "item_Sprite_Text";
            this.item_Sprite_Text.Size = new System.Drawing.Size(178, 22);
            this.item_Sprite_Text.Text = "Text";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // item_Geometry_Cube
            // 
            this.item_Geometry_Cube.Name = "item_Geometry_Cube";
            this.item_Geometry_Cube.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Cube.Text = "Cube";
            // 
            // item_Geometry_Cylinder
            // 
            this.item_Geometry_Cylinder.Name = "item_Geometry_Cylinder";
            this.item_Geometry_Cylinder.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Cylinder.Text = "Cylinder";
            // 
            // item_Geometry_IcoSphere
            // 
            this.item_Geometry_IcoSphere.Name = "item_Geometry_IcoSphere";
            this.item_Geometry_IcoSphere.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_IcoSphere.Text = "IcoSphere";
            // 
            // item_Geometry_Plane
            // 
            this.item_Geometry_Plane.Name = "item_Geometry_Plane";
            this.item_Geometry_Plane.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Plane.Text = "Plane";
            // 
            // item_Geometry_Pyramid
            // 
            this.item_Geometry_Pyramid.Name = "item_Geometry_Pyramid";
            this.item_Geometry_Pyramid.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Pyramid.Text = "Pyramid";
            // 
            // item_Geometry_Sphere
            // 
            this.item_Geometry_Sphere.Name = "item_Geometry_Sphere";
            this.item_Geometry_Sphere.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Sphere.Text = "Sphere";
            // 
            // item_Geometry_Torus
            // 
            this.item_Geometry_Torus.Name = "item_Geometry_Torus";
            this.item_Geometry_Torus.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Torus.Text = "Torus";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // item_Terrain_Simple
            // 
            this.item_Terrain_Simple.Name = "item_Terrain_Simple";
            this.item_Terrain_Simple.Size = new System.Drawing.Size(178, 22);
            this.item_Terrain_Simple.Text = "Terrain (Simple)";
            // 
            // item_Terrain_Heightmap
            // 
            this.item_Terrain_Heightmap.Name = "item_Terrain_Heightmap";
            this.item_Terrain_Heightmap.Size = new System.Drawing.Size(178, 22);
            this.item_Terrain_Heightmap.Text = "Terrain (Heighmap)";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.renderMenuItem_Click);
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
            // renderMenuItem
            // 
            this.renderMenuItem.Name = "renderMenuItem";
            this.renderMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renderMenuItem.Text = "Render";
            this.renderMenuItem.Click += new System.EventHandler(this.renderMenuItem_Click);
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
            this.mainSplitContainer.Size = new System.Drawing.Size(821, 537);
            this.mainSplitContainer.SplitterDistance = 575;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // glGameControl
            // 
            this.glGameControl.BackColor = System.Drawing.Color.Black;
            this.glGameControl.Location = new System.Drawing.Point(0, 0);
            this.glGameControl.Name = "glGameControl";
            this.glGameControl.Size = new System.Drawing.Size(572, 537);
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
            this.splitContainer2.Panel1.Controls.Add(this.panelGameObject);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(242, 537);
            this.splitContainer2.SplitterDistance = 371;
            this.splitContainer2.TabIndex = 0;
            // 
            // panelGameObject
            // 
            this.panelGameObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGameObject.AutoScroll = true;
            this.panelGameObject.Controls.Add(this.gameObjectControl1);
            this.panelGameObject.Controls.Add(this.transformControl1);
            this.panelGameObject.Controls.Add(this.spriteControl1);
            this.panelGameObject.Controls.Add(this.textControl1);
            this.panelGameObject.Location = new System.Drawing.Point(3, 3);
            this.panelGameObject.Name = "panelGameObject";
            this.panelGameObject.Size = new System.Drawing.Size(236, 365);
            this.panelGameObject.TabIndex = 0;
            // 
            // gameObjectControl1
            // 
            this.gameObjectControl1.Location = new System.Drawing.Point(3, 3);
            this.gameObjectControl1.Name = "gameObjectControl1";
            this.gameObjectControl1.Size = new System.Drawing.Size(215, 125);
            this.gameObjectControl1.TabIndex = 0;
            // 
            // transformControl1
            // 
            this.transformControl1.Location = new System.Drawing.Point(3, 134);
            this.transformControl1.Name = "transformControl1";
            this.transformControl1.Size = new System.Drawing.Size(215, 102);
            this.transformControl1.TabIndex = 1;
            // 
            // spriteControl1
            // 
            this.spriteControl1.Location = new System.Drawing.Point(3, 242);
            this.spriteControl1.Name = "spriteControl1";
            this.spriteControl1.Size = new System.Drawing.Size(215, 134);
            this.spriteControl1.TabIndex = 2;
            // 
            // textControl1
            // 
            this.textControl1.Location = new System.Drawing.Point(3, 382);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(215, 77);
            this.textControl1.TabIndex = 3;
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
            this.tabControl1.Size = new System.Drawing.Size(236, 159);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sceneTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(228, 133);
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
            this.sceneTreeView.Size = new System.Drawing.Size(228, 124);
            this.sceneTreeView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.assetsTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(228, 133);
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
            this.assetsTreeView.Size = new System.Drawing.Size(177, 352);
            this.assetsTreeView.TabIndex = 0;
            // 
            // item_Geometry_Empty
            // 
            this.item_Geometry_Empty.Name = "item_Geometry_Empty";
            this.item_Geometry_Empty.Size = new System.Drawing.Size(178, 22);
            this.item_Geometry_Empty.Text = "Empty";
            // 
            // MainEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainEditorForm";
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
            this.panelGameObject.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameObjectToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView sceneTreeView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView assetsTreeView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItem_GameObject;
        private System.Windows.Forms.ToolStripMenuItem item_Sprite_Group;
        private System.Windows.Forms.ToolStripMenuItem item_Sprite_Particles;
        private System.Windows.Forms.ToolStripMenuItem item_Sprite_Sprite;
        private System.Windows.Forms.ToolStripMenuItem item_Sprite_Text;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Cube;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Cylinder;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_IcoSphere;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Plane;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Pyramid;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Sphere;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Torus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem item_Terrain_Simple;
        private System.Windows.Forms.ToolStripMenuItem item_Terrain_Heightmap;
        private System.Windows.Forms.ToolStripMenuItem item_Geometry_Empty;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelGameObject;
        private Components.GameObjectControl gameObjectControl1;
        private Components.TransformControl transformControl1;
        private Components.SpriteControl spriteControl1;
        private Components.TextControl textControl1;
        private EditorGameControl glGameControl;
    }
}

