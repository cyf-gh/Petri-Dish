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
            this.verifyAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectGithubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withPowerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHOWTOUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker_LoadHowToUse = new System.ComponentModel.BackgroundWorker();
            this.petriDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setProjectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesToolStripMenuItem,
            this.verifyAllDataToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.editToolStripMenuItem.Text = "Edit Json...";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameDataToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.languageToolStripMenuItem1});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // gameDataToolStripMenuItem1
            // 
            this.gameDataToolStripMenuItem1.Name = "gameDataToolStripMenuItem1";
            this.gameDataToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.gameDataToolStripMenuItem1.Text = "Game Data";
            this.gameDataToolStripMenuItem1.Click += new System.EventHandler(this.gameDataToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            this.languageToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.languageToolStripMenuItem1.Text = "Language";
            // 
            // verifyAllDataToolStripMenuItem
            // 
            this.verifyAllDataToolStripMenuItem.Name = "verifyAllDataToolStripMenuItem";
            this.verifyAllDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verifyAllDataToolStripMenuItem.Text = "Verify All";
            this.verifyAllDataToolStripMenuItem.Click += new System.EventHandler(this.VerifyAllDataToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectSceneToolStripMenuItem,
            this.openProjectFolderToolStripMenuItem,
            this.openProjectGithubPageToolStripMenuItem,
            this.withPowerShellToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(105, 21);
            this.projectToolStripMenuItem.Text = "Open Project...";
            // 
            // openProjectSceneToolStripMenuItem
            // 
            this.openProjectSceneToolStripMenuItem.Name = "openProjectSceneToolStripMenuItem";
            this.openProjectSceneToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openProjectSceneToolStripMenuItem.Text = "Scene";
            this.openProjectSceneToolStripMenuItem.Click += new System.EventHandler(this.openProjectSceneToolStripMenuItem_Click);
            // 
            // openProjectFolderToolStripMenuItem
            // 
            this.openProjectFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem,
            this.assestToolStripMenuItem});
            this.openProjectFolderToolStripMenuItem.Name = "openProjectFolderToolStripMenuItem";
            this.openProjectFolderToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openProjectFolderToolStripMenuItem.Text = "Folder";
            this.openProjectFolderToolStripMenuItem.Click += new System.EventHandler(this.openProjectFolderToolStripMenuItem_Click);
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            this.rootToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.rootToolStripMenuItem.Text = "Root";
            this.rootToolStripMenuItem.Click += new System.EventHandler(this.rootToolStripMenuItem_Click);
            // 
            // assestToolStripMenuItem
            // 
            this.assestToolStripMenuItem.Name = "assestToolStripMenuItem";
            this.assestToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.assestToolStripMenuItem.Text = "Assest";
            this.assestToolStripMenuItem.Click += new System.EventHandler(this.assestToolStripMenuItem_Click);
            // 
            // openProjectGithubPageToolStripMenuItem
            // 
            this.openProjectGithubPageToolStripMenuItem.Name = "openProjectGithubPageToolStripMenuItem";
            this.openProjectGithubPageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openProjectGithubPageToolStripMenuItem.Text = "Github Page";
            this.openProjectGithubPageToolStripMenuItem.Click += new System.EventHandler(this.openProjectGithubPageToolStripMenuItem_Click);
            // 
            // withPowerShellToolStripMenuItem
            // 
            this.withPowerShellToolStripMenuItem.Name = "withPowerShellToolStripMenuItem";
            this.withPowerShellToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.withPowerShellToolStripMenuItem.Text = "With PowerShell";
            this.withPowerShellToolStripMenuItem.Click += new System.EventHandler(this.withPowerShellToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setProjectDirectoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHOWTOUSEToolStripMenuItem,
            this.checkUpdateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.petriDishToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // viewHOWTOUSEToolStripMenuItem
            // 
            this.viewHOWTOUSEToolStripMenuItem.Name = "viewHOWTOUSEToolStripMenuItem";
            this.viewHOWTOUSEToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewHOWTOUSEToolStripMenuItem.Text = "View How to use";
            this.viewHOWTOUSEToolStripMenuItem.Click += new System.EventHandler(this.ViewHOWTOUSEToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(22, 24);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1019, 714);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // backgroundWorker_LoadHowToUse
            // 
            this.backgroundWorker_LoadHowToUse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_LoadHowToUse_DoWork);
            // 
            // petriDishToolStripMenuItem
            // 
            this.petriDishToolStripMenuItem.Name = "petriDishToolStripMenuItem";
            this.petriDishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petriDishToolStripMenuItem.Text = "Petri-Dish";
            this.petriDishToolStripMenuItem.Click += new System.EventHandler(this.PetriDishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "------------";
            // 
            // checkUpdateToolStripMenuItem
            // 
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            this.checkUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkUpdateToolStripMenuItem.Text = "Check update";
            this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckUpdateToolStripMenuItem_Click);
            // 
            // setProjectDirectoryToolStripMenuItem
            // 
            this.setProjectDirectoryToolStripMenuItem.Name = "setProjectDirectoryToolStripMenuItem";
            this.setProjectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.setProjectDirectoryToolStripMenuItem.Text = "Set Project Directory";
            this.setProjectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setProjectDirectoryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 739);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ToolStripMenuItem viewHOWTOUSEToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_LoadHowToUse;
        private System.Windows.Forms.ToolStripMenuItem verifyAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petriDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem setProjectDirectoryToolStripMenuItem;
    }
}