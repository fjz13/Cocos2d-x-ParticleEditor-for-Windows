namespace ParticleEditor
{
    partial class ParticleEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticleEditorForm));
            this.mMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sameplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fireworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galaxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meteorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modernArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiusMode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiusMode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStatusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mPlayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mEditorPanel = new System.Windows.Forms.Panel();
            this.mPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.mTimer = new System.Windows.Forms.Timer(this.components);
            this.mMenuStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenuStrip
            // 
            this.mMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sameplesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMenuStrip.Name = "mMenuStrip";
            this.mMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mMenuStrip.Size = new System.Drawing.Size(1924, 28);
            this.mMenuStrip.TabIndex = 0;
            this.mMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // sameplesToolStripMenuItem
            // 
            this.sameplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fireworksToolStripMenuItem,
            this.sunToolStripMenuItem,
            this.smokeToolStripMenuItem,
            this.sprialToolStripMenuItem,
            this.flowerToolStripMenuItem,
            this.bigFlowerToolStripMenuItem,
            this.rotFlowerToolStripMenuItem,
            this.explosionToolStripMenuItem,
            this.galaxyToolStripMenuItem,
            this.meteorToolStripMenuItem,
            this.modernArtToolStripMenuItem,
            this.radiusMode1ToolStripMenuItem,
            this.radiusMode2ToolStripMenuItem,
            this.snowToolStripMenuItem,
            this.rainToolStripMenuItem,
            this.ringToolStripMenuItem});
            this.sameplesToolStripMenuItem.Name = "sameplesToolStripMenuItem";
            this.sameplesToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.sameplesToolStripMenuItem.Text = "Samples";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem1.Text = "Fire";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fireworksToolStripMenuItem
            // 
            this.fireworksToolStripMenuItem.Name = "fireworksToolStripMenuItem";
            this.fireworksToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.fireworksToolStripMenuItem.Text = "Fireworks";
            this.fireworksToolStripMenuItem.Click += new System.EventHandler(this.fireworksToolStripMenuItem_Click);
            // 
            // sunToolStripMenuItem
            // 
            this.sunToolStripMenuItem.Name = "sunToolStripMenuItem";
            this.sunToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.sunToolStripMenuItem.Text = "Sun";
            this.sunToolStripMenuItem.Click += new System.EventHandler(this.sunToolStripMenuItem_Click);
            // 
            // smokeToolStripMenuItem
            // 
            this.smokeToolStripMenuItem.Name = "smokeToolStripMenuItem";
            this.smokeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.smokeToolStripMenuItem.Text = "Smoke";
            this.smokeToolStripMenuItem.Click += new System.EventHandler(this.smokeToolStripMenuItem_Click);
            // 
            // sprialToolStripMenuItem
            // 
            this.sprialToolStripMenuItem.Name = "sprialToolStripMenuItem";
            this.sprialToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.sprialToolStripMenuItem.Text = "Spiral";
            this.sprialToolStripMenuItem.Click += new System.EventHandler(this.spiralToolStripMenuItem_Click);
            // 
            // flowerToolStripMenuItem
            // 
            this.flowerToolStripMenuItem.Name = "flowerToolStripMenuItem";
            this.flowerToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.flowerToolStripMenuItem.Text = "Flower";
            this.flowerToolStripMenuItem.Click += new System.EventHandler(this.flowerToolStripMenuItem_Click);
            // 
            // bigFlowerToolStripMenuItem
            // 
            this.bigFlowerToolStripMenuItem.Name = "bigFlowerToolStripMenuItem";
            this.bigFlowerToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.bigFlowerToolStripMenuItem.Text = "BigFlower";
            this.bigFlowerToolStripMenuItem.Click += new System.EventHandler(this.bigFlowerToolStripMenuItem_Click);
            // 
            // rotFlowerToolStripMenuItem
            // 
            this.rotFlowerToolStripMenuItem.Name = "rotFlowerToolStripMenuItem";
            this.rotFlowerToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.rotFlowerToolStripMenuItem.Text = "RotFlower";
            this.rotFlowerToolStripMenuItem.Click += new System.EventHandler(this.rotFlowerToolStripMenuItem_Click);
            // 
            // explosionToolStripMenuItem
            // 
            this.explosionToolStripMenuItem.Name = "explosionToolStripMenuItem";
            this.explosionToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.explosionToolStripMenuItem.Text = "Explosion";
            this.explosionToolStripMenuItem.Click += new System.EventHandler(this.explosionToolStripMenuItem_Click);
            // 
            // galaxyToolStripMenuItem
            // 
            this.galaxyToolStripMenuItem.Name = "galaxyToolStripMenuItem";
            this.galaxyToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.galaxyToolStripMenuItem.Text = "Galaxy";
            this.galaxyToolStripMenuItem.Click += new System.EventHandler(this.galaxyToolStripMenuItem_Click);
            // 
            // meteorToolStripMenuItem
            // 
            this.meteorToolStripMenuItem.Name = "meteorToolStripMenuItem";
            this.meteorToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.meteorToolStripMenuItem.Text = "Meteor";
            this.meteorToolStripMenuItem.Click += new System.EventHandler(this.meteorToolStripMenuItem_Click);
            // 
            // modernArtToolStripMenuItem
            // 
            this.modernArtToolStripMenuItem.Name = "modernArtToolStripMenuItem";
            this.modernArtToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.modernArtToolStripMenuItem.Text = "ModernArt";
            this.modernArtToolStripMenuItem.Click += new System.EventHandler(this.modernArtToolStripMenuItem_Click);
            // 
            // radiusMode1ToolStripMenuItem
            // 
            this.radiusMode1ToolStripMenuItem.Name = "radiusMode1ToolStripMenuItem";
            this.radiusMode1ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.radiusMode1ToolStripMenuItem.Text = "RadiusMode1";
            this.radiusMode1ToolStripMenuItem.Click += new System.EventHandler(this.radiusMode1ToolStripMenuItem_Click);
            // 
            // radiusMode2ToolStripMenuItem
            // 
            this.radiusMode2ToolStripMenuItem.Name = "radiusMode2ToolStripMenuItem";
            this.radiusMode2ToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.radiusMode2ToolStripMenuItem.Text = "RadiusMode2";
            this.radiusMode2ToolStripMenuItem.Click += new System.EventHandler(this.radiusMode2ToolStripMenuItem_Click);
            // 
            // snowToolStripMenuItem
            // 
            this.snowToolStripMenuItem.Name = "snowToolStripMenuItem";
            this.snowToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.snowToolStripMenuItem.Text = "Snow";
            this.snowToolStripMenuItem.Click += new System.EventHandler(this.snowToolStripMenuItem_Click);
            // 
            // rainToolStripMenuItem
            // 
            this.rainToolStripMenuItem.Name = "rainToolStripMenuItem";
            this.rainToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.rainToolStripMenuItem.Text = "Rain";
            this.rainToolStripMenuItem.Click += new System.EventHandler(this.rainToolStripMenuItem_Click);
            // 
            // ringToolStripMenuItem
            // 
            this.ringToolStripMenuItem.Name = "ringToolStripMenuItem";
            this.ringToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.ringToolStripMenuItem.Text = "Ring";
            this.ringToolStripMenuItem.Click += new System.EventHandler(this.ringToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mStatusStrip
            // 
            this.mStatusStrip.Location = new System.Drawing.Point(0, 822);
            this.mStatusStrip.Name = "mStatusStrip";
            this.mStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mStatusStrip.Size = new System.Drawing.Size(1924, 22);
            this.mStatusStrip.TabIndex = 1;
            this.mStatusStrip.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.mEditorPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 794);
            this.splitContainer1.SplitterDistance = 1267;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPlayToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1267, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mPlayToolStripButton
            // 
            this.mPlayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mPlayToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mPlayToolStripButton.Image")));
            this.mPlayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mPlayToolStripButton.Name = "mPlayToolStripButton";
            this.mPlayToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.mPlayToolStripButton.Text = "播放";
            this.mPlayToolStripButton.Click += new System.EventHandler(this.mPlayToolStripButton_Click);
            // 
            // mEditorPanel
            // 
            this.mEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mEditorPanel.Location = new System.Drawing.Point(0, 0);
            this.mEditorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mEditorPanel.Name = "mEditorPanel";
            this.mEditorPanel.Size = new System.Drawing.Size(1267, 794);
            this.mEditorPanel.TabIndex = 0;
            // 
            // mPropertyGrid
            // 
            this.mPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.mPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mPropertyGrid.Name = "mPropertyGrid";
            this.mPropertyGrid.Size = new System.Drawing.Size(652, 794);
            this.mPropertyGrid.TabIndex = 0;
            this.mPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGridPropertyValueChanged);
            // 
            // mTimer
            // 
            this.mTimer.Enabled = true;
            this.mTimer.Interval = 10;
            this.mTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // ParticleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 844);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mStatusStrip);
            this.Controls.Add(this.mMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParticleEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocos2d Particle Editor V2.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticleEditorFormFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParticleEditorFormFormClosed);
            this.Load += new System.EventHandler(this.FormLoad);
            this.mMenuStrip.ResumeLayout(false);
            this.mMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mStatusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel mEditorPanel;
        private System.Windows.Forms.Timer mTimer;
        private System.Windows.Forms.PropertyGrid mPropertyGrid;
        private System.Windows.Forms.ToolStripMenuItem sameplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fireworksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigFlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotFlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galaxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meteorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modernArtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiusMode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiusMode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ringToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mPlayToolStripButton;
    }
}

