namespace PetriDish.App.Forms
{
    partial class RaceHelperForm
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
            this.clb_regs = new System.Windows.Forms.CheckedListBox();
            this.lb_cods = new System.Windows.Forms.ListBox();
            this.lb_cur_cods = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gen_res = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_regs
            // 
            this.clb_regs.FormattingEnabled = true;
            this.clb_regs.Location = new System.Drawing.Point(12, 12);
            this.clb_regs.Name = "clb_regs";
            this.clb_regs.Size = new System.Drawing.Size(221, 418);
            this.clb_regs.TabIndex = 0;
            this.clb_regs.SelectedIndexChanged += new System.EventHandler(this.Clb_regs_SelectedIndexChanged);
            // 
            // lb_cods
            // 
            this.lb_cods.FormattingEnabled = true;
            this.lb_cods.ItemHeight = 18;
            this.lb_cods.Location = new System.Drawing.Point(485, 12);
            this.lb_cods.Name = "lb_cods";
            this.lb_cods.Size = new System.Drawing.Size(224, 418);
            this.lb_cods.TabIndex = 2;
            this.lb_cods.DoubleClick += new System.EventHandler(this.Lb_cods_DoubleClick);
            // 
            // lb_cur_cods
            // 
            this.lb_cur_cods.FormattingEnabled = true;
            this.lb_cur_cods.ItemHeight = 18;
            this.lb_cur_cods.Location = new System.Drawing.Point(239, 12);
            this.lb_cur_cods.Name = "lb_cur_cods";
            this.lb_cur_cods.Size = new System.Drawing.Size(240, 418);
            this.lb_cur_cods.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(697, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate And Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gen_res
            // 
            this.gen_res.Location = new System.Drawing.Point(12, 436);
            this.gen_res.Name = "gen_res";
            this.gen_res.Size = new System.Drawing.Size(697, 28);
            this.gen_res.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RaceHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gen_res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_cur_cods);
            this.Controls.Add(this.lb_cods);
            this.Controls.Add(this.clb_regs);
            this.Name = "RaceHelperForm";
            this.Text = "Gene Names Generator";
            this.Load += new System.EventHandler(this.RaceHelperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_regs;
        private System.Windows.Forms.ListBox lb_cods;
        private System.Windows.Forms.ListBox lb_cur_cods;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gen_res;
        private System.Windows.Forms.Button button2;
    }
}