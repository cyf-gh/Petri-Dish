﻿using ZTn.Json.JsonTreeView.Controls;

namespace ZTn.Json.Editor.Forms
{
    partial class JsonEditorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonEditorMainForm));
            this.jsonTreeViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.jTokenTree = new ZTn.Json.JsonTreeView.Controls.JTokenTreeUserControl();
            this.jsonTypeComboBox = new System.Windows.Forms.ComboBox();
            this.jsonValueTextBox = new System.Windows.Forms.TextBox();
            this.jsonValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newtonsoftJsonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutJsonEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiStatusStrip = new System.Windows.Forms.StatusStrip();
            this.actionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.jsonStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).BeginInit();
            this.jsonTreeViewSplitContainer.Panel1.SuspendLayout();
            this.jsonTreeViewSplitContainer.Panel2.SuspendLayout();
            this.jsonTreeViewSplitContainer.SuspendLayout();
            this.formMenuStrip.SuspendLayout();
            this.guiStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonTreeViewSplitContainer
            // 
            this.jsonTreeViewSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTreeViewSplitContainer.Location = new System.Drawing.Point(0, 28);
            this.jsonTreeViewSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jsonTreeViewSplitContainer.Name = "jsonTreeViewSplitContainer";
            // 
            // jsonTreeViewSplitContainer.Panel1
            // 
            this.jsonTreeViewSplitContainer.Panel1.Controls.Add(this.jTokenTree);
            this.jsonTreeViewSplitContainer.Panel1MinSize = 200;
            // 
            // jsonTreeViewSplitContainer.Panel2
            // 
            this.jsonTreeViewSplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonTypeComboBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonValueTextBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonValueLabel);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.label2);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.newtonsoftJsonTypeTextBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.label1);
            this.jsonTreeViewSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.jsonTreeViewSplitContainer_Panel2_Paint);
            this.jsonTreeViewSplitContainer.Panel2MinSize = 320;
            this.jsonTreeViewSplitContainer.Size = new System.Drawing.Size(1344, 637);
            this.jsonTreeViewSplitContainer.SplitterDistance = 896;
            this.jsonTreeViewSplitContainer.SplitterWidth = 5;
            this.jsonTreeViewSplitContainer.TabIndex = 8;
            // 
            // jTokenTree
            // 
            this.jTokenTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jTokenTree.CollapsedFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jTokenTree.ExpandedFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Underline);
            this.jTokenTree.Location = new System.Drawing.Point(4, 3);
            this.jTokenTree.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.jTokenTree.Name = "jTokenTree";
            this.jTokenTree.Size = new System.Drawing.Size(545, 456);
            this.jTokenTree.TabIndex = 2;
            this.jTokenTree.AfterSelect += new System.EventHandler<ZTn.Json.JsonTreeView.AfterSelectEventArgs>(this.jTokenTree_AfterSelect);
            // 
            // jsonTypeComboBox
            // 
            this.jsonTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jsonTypeComboBox.Enabled = false;
            this.jsonTypeComboBox.FormattingEnabled = true;
            this.jsonTypeComboBox.Location = new System.Drawing.Point(4, 68);
            this.jsonTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jsonTypeComboBox.Name = "jsonTypeComboBox";
            this.jsonTypeComboBox.Size = new System.Drawing.Size(204, 23);
            this.jsonTypeComboBox.TabIndex = 7;
            // 
            // jsonValueTextBox
            // 
            this.jsonValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonValueTextBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.jsonValueTextBox.Location = new System.Drawing.Point(4, 112);
            this.jsonValueTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jsonValueTextBox.Multiline = true;
            this.jsonValueTextBox.Name = "jsonValueTextBox";
            this.jsonValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonValueTextBox.Size = new System.Drawing.Size(244, 347);
            this.jsonValueTextBox.TabIndex = 6;
            this.jsonValueTextBox.Enter += new System.EventHandler(this.jsonValueTextBox_Enter);
            this.jsonValueTextBox.Leave += new System.EventHandler(this.jsonValueTextBox_Leave);
            // 
            // jsonValueLabel
            // 
            this.jsonValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jsonValueLabel.AutoSize = true;
            this.jsonValueLabel.Location = new System.Drawing.Point(4, 93);
            this.jsonValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jsonValueLabel.Name = "jsonValueLabel";
            this.jsonValueLabel.Size = new System.Drawing.Size(87, 15);
            this.jsonValueLabel.TabIndex = 5;
            this.jsonValueLabel.Text = "JSON Value";
            this.jsonValueLabel.TextChanged += new System.EventHandler(this.jsonValueTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "NewtonSoft.Json Type";
            // 
            // newtonsoftJsonTypeTextBox
            // 
            this.newtonsoftJsonTypeTextBox.Location = new System.Drawing.Point(4, 22);
            this.newtonsoftJsonTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newtonsoftJsonTypeTextBox.Name = "newtonsoftJsonTypeTextBox";
            this.newtonsoftJsonTypeTextBox.ReadOnly = true;
            this.newtonsoftJsonTypeTextBox.Size = new System.Drawing.Size(204, 25);
            this.newtonsoftJsonTypeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "JSON Type";
            // 
            // formMenuStrip
            // 
            this.formMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMenuStrip.Name = "formMenuStrip";
            this.formMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.formMenuStrip.Size = new System.Drawing.Size(1344, 27);
            this.formMenuStrip.TabIndex = 0;
            this.formMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJsonObjectToolStripMenuItem,
            this.newJsonArrayToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShowShortcutKeys = false;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // newJsonObjectToolStripMenuItem
            // 
            this.newJsonObjectToolStripMenuItem.Name = "newJsonObjectToolStripMenuItem";
            this.newJsonObjectToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.newJsonObjectToolStripMenuItem.Text = "New Json &Object";
            this.newJsonObjectToolStripMenuItem.Click += new System.EventHandler(this.newJsonObjectToolStripMenuItem_Click);
            // 
            // newJsonArrayToolStripMenuItem
            // 
            this.newJsonArrayToolStripMenuItem.Name = "newJsonArrayToolStripMenuItem";
            this.newJsonArrayToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.newJsonArrayToolStripMenuItem.Text = "New Json &Array";
            this.newJsonArrayToolStripMenuItem.Click += new System.EventHandler(this.newJsonArrayToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutJsonEditorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(27, 23);
            this.aboutToolStripMenuItem.Text = "?";
            // 
            // aboutJsonEditorToolStripMenuItem
            // 
            this.aboutJsonEditorToolStripMenuItem.Name = "aboutJsonEditorToolStripMenuItem";
            this.aboutJsonEditorToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.aboutJsonEditorToolStripMenuItem.Text = "About Json Editor";
            this.aboutJsonEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutJsonEditorToolStripMenuItem_Click);
            // 
            // guiStatusStrip
            // 
            this.guiStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guiStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionStatusLabel,
            this.toolStripStatusLabel1,
            this.jsonStatusLabel});
            this.guiStatusStrip.Location = new System.Drawing.Point(0, 669);
            this.guiStatusStrip.Name = "guiStatusStrip";
            this.guiStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.guiStatusStrip.Size = new System.Drawing.Size(1344, 24);
            this.guiStatusStrip.TabIndex = 9;
            this.guiStatusStrip.Text = "statusStrip";
            // 
            // actionStatusLabel
            // 
            this.actionStatusLabel.Name = "actionStatusLabel";
            this.actionStatusLabel.Size = new System.Drawing.Size(53, 19);
            this.actionStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1185, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // jsonStatusLabel
            // 
            this.jsonStatusLabel.Name = "jsonStatusLabel";
            this.jsonStatusLabel.Size = new System.Drawing.Size(86, 19);
            this.jsonStatusLabel.Text = "JsonStatus";
            // 
            // JsonEditorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 693);
            this.Controls.Add(this.guiStatusStrip);
            this.Controls.Add(this.jsonTreeViewSplitContainer);
            this.Controls.Add(this.formMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.formMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "JsonEditorMainForm";
            this.Text = "ZTn Json Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JsonEditorMainForm_FormClosing);
            this.Load += new System.EventHandler(this.JsonEditorMainForm_Load);
            this.jsonTreeViewSplitContainer.Panel1.ResumeLayout(false);
            this.jsonTreeViewSplitContainer.Panel2.ResumeLayout(false);
            this.jsonTreeViewSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).EndInit();
            this.jsonTreeViewSplitContainer.ResumeLayout(false);
            this.formMenuStrip.ResumeLayout(false);
            this.formMenuStrip.PerformLayout();
            this.guiStatusStrip.ResumeLayout(false);
            this.guiStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtonsoftJsonTypeTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label jsonValueLabel;
        private System.Windows.Forms.SplitContainer jsonTreeViewSplitContainer;
        private System.Windows.Forms.TextBox jsonValueTextBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonArrayToolStripMenuItem;
        private System.Windows.Forms.ComboBox jsonTypeComboBox;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutJsonEditorToolStripMenuItem;
        private JTokenTreeUserControl jTokenTree;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip guiStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel actionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel jsonStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

