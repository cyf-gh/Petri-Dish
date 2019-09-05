namespace PetriDish.App {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectGithubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withPowerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setProjectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.editToolStripMenuItem.Text = "Edit ...";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameDataToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.languageToolStripMenuItem1});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // gameDataToolStripMenuItem1
            // 
            this.gameDataToolStripMenuItem1.Name = "gameDataToolStripMenuItem1";
            this.gameDataToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.gameDataToolStripMenuItem1.Text = "Game Data";
            this.gameDataToolStripMenuItem1.Click += new System.EventHandler(this.gameDataToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            this.languageToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.languageToolStripMenuItem1.Text = "Language";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectSceneToolStripMenuItem,
            this.openProjectFolderToolStripMenuItem,
            this.openProjectGithubPageToolStripMenuItem,
            this.withPowerShellToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(125, 23);
            this.projectToolStripMenuItem.Text = "Open Project...";
            // 
            // openProjectSceneToolStripMenuItem
            // 
            this.openProjectSceneToolStripMenuItem.Name = "openProjectSceneToolStripMenuItem";
            this.openProjectSceneToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.openProjectSceneToolStripMenuItem.Text = "Scene";
            this.openProjectSceneToolStripMenuItem.Click += new System.EventHandler(this.openProjectSceneToolStripMenuItem_Click);
            // 
            // openProjectFolderToolStripMenuItem
            // 
            this.openProjectFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem,
            this.assestToolStripMenuItem});
            this.openProjectFolderToolStripMenuItem.Name = "openProjectFolderToolStripMenuItem";
            this.openProjectFolderToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.openProjectFolderToolStripMenuItem.Text = "Folder";
            this.openProjectFolderToolStripMenuItem.Click += new System.EventHandler(this.openProjectFolderToolStripMenuItem_Click);
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            this.rootToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.rootToolStripMenuItem.Text = "Root";
            this.rootToolStripMenuItem.Click += new System.EventHandler(this.rootToolStripMenuItem_Click);
            // 
            // assestToolStripMenuItem
            // 
            this.assestToolStripMenuItem.Name = "assestToolStripMenuItem";
            this.assestToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.assestToolStripMenuItem.Text = "Assest";
            this.assestToolStripMenuItem.Click += new System.EventHandler(this.assestToolStripMenuItem_Click);
            // 
            // openProjectGithubPageToolStripMenuItem
            // 
            this.openProjectGithubPageToolStripMenuItem.Name = "openProjectGithubPageToolStripMenuItem";
            this.openProjectGithubPageToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.openProjectGithubPageToolStripMenuItem.Text = "Github Page";
            this.openProjectGithubPageToolStripMenuItem.Click += new System.EventHandler(this.openProjectGithubPageToolStripMenuItem_Click);
            // 
            // withPowerShellToolStripMenuItem
            // 
            this.withPowerShellToolStripMenuItem.Name = "withPowerShellToolStripMenuItem";
            this.withPowerShellToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.withPowerShellToolStripMenuItem.Text = "With PowerShell";
            this.withPowerShellToolStripMenuItem.Click += new System.EventHandler(this.withPowerShellToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setProjectDirectoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setProjectDirectoryToolStripMenuItem
            // 
            this.setProjectDirectoryToolStripMenuItem.Name = "setProjectDirectoryToolStripMenuItem";
            this.setProjectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.setProjectDirectoryToolStripMenuItem.Text = "Set Project Directory";
            this.setProjectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setProjectDirectoryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(906, 589);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://github.com/cyf-gh/Petri-Dish/blob/master/README.md", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 616);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petri-Dish";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setProjectDirectoryToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectGithubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assestToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem withPowerShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}