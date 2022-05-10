namespace GUI
{
    partial class AlternateApps
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
            this.label3 = new System.Windows.Forms.Label();
            this.stress_clb = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betaApps_clb = new System.Windows.Forms.CheckedListBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.install_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stress Testing";
            // 
            // stress_clb
            // 
            this.stress_clb.CheckOnClick = true;
            this.stress_clb.FormattingEnabled = true;
            this.stress_clb.Items.AddRange(new object[] {
            "blender",
            "boinc"});
            this.stress_clb.Location = new System.Drawing.Point(174, 27);
            this.stress_clb.Name = "stress_clb";
            this.stress_clb.Size = new System.Drawing.Size(156, 40);
            this.stress_clb.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Beta Apps";
            // 
            // betaApps_clb
            // 
            this.betaApps_clb.CheckOnClick = true;
            this.betaApps_clb.FormattingEnabled = true;
            this.betaApps_clb.Items.AddRange(new object[] {
            "brave-beta",
            "brave-devel",
            "chrome-beta",
            "chrome-devel",
            "everything-alpha",
            "everything-lite",
            "firefox-beta",
            "firefox-devel",
            "opera-beta",
            "vscode-devel"});
            this.betaApps_clb.Location = new System.Drawing.Point(12, 27);
            this.betaApps_clb.Name = "betaApps_clb";
            this.betaApps_clb.Size = new System.Drawing.Size(156, 184);
            this.betaApps_clb.TabIndex = 16;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(255, 187);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // install_btn
            // 
            this.install_btn.Location = new System.Drawing.Point(174, 187);
            this.install_btn.Name = "install_btn";
            this.install_btn.Size = new System.Drawing.Size(75, 23);
            this.install_btn.TabIndex = 20;
            this.install_btn.Text = "Install";
            this.install_btn.UseVisualStyleBackColor = true;
            this.install_btn.Click += new System.EventHandler(this.install_btn_Click);
            // 
            // AlternateApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.install_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stress_clb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betaApps_clb);
            this.Name = "AlternateApps";
            this.Text = "Beta and Stress Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox stress_clb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox betaApps_clb;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button install_btn;
    }
}