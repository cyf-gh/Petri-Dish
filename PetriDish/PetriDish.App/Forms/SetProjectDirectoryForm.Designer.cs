namespace PetriDish.App {
    partial class SetProjectDirectoryForm {
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
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.static_label1 = new System.Windows.Forms.Label();
            this.btn_selectDirectory = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_directory
            // 
            this.tb_directory.Location = new System.Drawing.Point(161, 12);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(418, 25);
            this.tb_directory.TabIndex = 0;
            // 
            // static_label1
            // 
            this.static_label1.AutoSize = true;
            this.static_label1.Location = new System.Drawing.Point(12, 15);
            this.static_label1.Name = "static_label1";
            this.static_label1.Size = new System.Drawing.Size(143, 15);
            this.static_label1.TabIndex = 2;
            this.static_label1.Text = "Project Directory";
            // 
            // btn_selectDirectory
            // 
            this.btn_selectDirectory.Location = new System.Drawing.Point(585, 12);
            this.btn_selectDirectory.Name = "btn_selectDirectory";
            this.btn_selectDirectory.Size = new System.Drawing.Size(203, 25);
            this.btn_selectDirectory.TabIndex = 1;
            this.btn_selectDirectory.Text = "Select Directory";
            this.btn_selectDirectory.UseVisualStyleBackColor = true;
            this.btn_selectDirectory.Click += new System.EventHandler(this.btn_selectDirectory_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(616, 134);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(172, 25);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "OK";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Example: C:\\Dev\\CellWar.Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SetProjectDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.static_label1);
            this.Controls.Add(this.btn_selectDirectory);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_directory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetProjectDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select CellWar.Game Directory";
            this.Load += new System.EventHandler(this.SetProjectDirectoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.Label static_label1;
        private System.Windows.Forms.Button btn_selectDirectory;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
    }
}