namespace GUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.apps_clb = new System.Windows.Forms.CheckedListBox();
            this.install_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.debloat_btn = new System.Windows.Forms.Button();
            this.tweak_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.av_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installWingetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alt_clear_btn = new System.Windows.Forms.Button();
            this.alt_install_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stress_clb = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betaApps_clb = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // apps_clb
            // 
            this.apps_clb.CheckOnClick = true;
            this.apps_clb.FormattingEnabled = true;
            this.apps_clb.Items.AddRange(new object[] {
            "7zip",
            "acrobat",
            "brave",
            "chrome",
            "everything",
            "everything-toolbar",
            "firefox",
            "firefox-esr",
            "flameshot",
            "gimp",
            "github-desktop",
            "greenshot",
            "krita",
            "librewolf",
            "m365",
            "npp",
            "onedrive",
            "opera",
            "opera-gx",
            "powertoys",
            "vlc",
            "vscode",
            "vscodium",
            "waterfox",
            "waterfox-classic"});
            this.apps_clb.Location = new System.Drawing.Point(0, 6);
            this.apps_clb.MultiColumn = true;
            this.apps_clb.Name = "apps_clb";
            this.apps_clb.Size = new System.Drawing.Size(404, 184);
            this.apps_clb.Sorted = true;
            this.apps_clb.TabIndex = 0;
            // 
            // install_btn
            // 
            this.install_btn.Location = new System.Drawing.Point(8, 196);
            this.install_btn.Name = "install_btn";
            this.install_btn.Size = new System.Drawing.Size(206, 23);
            this.install_btn.TabIndex = 1;
            this.install_btn.Text = "Install";
            this.install_btn.UseVisualStyleBackColor = true;
            this.install_btn.Click += new System.EventHandler(this.install_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(220, 196);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(205, 23);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // debloat_btn
            // 
            this.debloat_btn.Location = new System.Drawing.Point(12, 287);
            this.debloat_btn.Name = "debloat_btn";
            this.debloat_btn.Size = new System.Drawing.Size(100, 23);
            this.debloat_btn.TabIndex = 3;
            this.debloat_btn.Text = "Debloat";
            this.debloat_btn.UseVisualStyleBackColor = true;
            this.debloat_btn.Click += new System.EventHandler(this.debloat_btn_Click);
            // 
            // tweak_btn
            // 
            this.tweak_btn.Location = new System.Drawing.Point(118, 287);
            this.tweak_btn.Name = "tweak_btn";
            this.tweak_btn.Size = new System.Drawing.Size(100, 23);
            this.tweak_btn.TabIndex = 4;
            this.tweak_btn.Text = "Apply Tweaks";
            this.tweak_btn.UseVisualStyleBackColor = true;
            this.tweak_btn.Click += new System.EventHandler(this.tweak_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(224, 287);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 23);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // av_btn
            // 
            this.av_btn.Location = new System.Drawing.Point(330, 287);
            this.av_btn.Name = "av_btn";
            this.av_btn.Size = new System.Drawing.Size(100, 23);
            this.av_btn.TabIndex = 5;
            this.av_btn.Text = "Anti-Virus";
            this.av_btn.UseVisualStyleBackColor = true;
            this.av_btn.Click += new System.EventHandler(this.av_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installWingetToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // installWingetToolStripMenuItem
            // 
            this.installWingetToolStripMenuItem.Name = "installWingetToolStripMenuItem";
            this.installWingetToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.installWingetToolStripMenuItem.Text = "Install winget";
            this.installWingetToolStripMenuItem.Click += new System.EventHandler(this.installWingetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 254);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.apps_clb);
            this.tabPage1.Controls.Add(this.install_btn);
            this.tabPage1.Controls.Add(this.clear_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.alt_clear_btn);
            this.tabPage2.Controls.Add(this.alt_install_btn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.stress_clb);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.betaApps_clb);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // alt_clear_btn
            // 
            this.alt_clear_btn.Location = new System.Drawing.Point(314, 197);
            this.alt_clear_btn.Name = "alt_clear_btn";
            this.alt_clear_btn.Size = new System.Drawing.Size(90, 23);
            this.alt_clear_btn.TabIndex = 27;
            this.alt_clear_btn.Text = "Clear";
            this.alt_clear_btn.UseVisualStyleBackColor = true;
            this.alt_clear_btn.Click += new System.EventHandler(this.alt_clear_btn_Click);
            // 
            // alt_install_btn
            // 
            this.alt_install_btn.Location = new System.Drawing.Point(314, 168);
            this.alt_install_btn.Name = "alt_install_btn";
            this.alt_install_btn.Size = new System.Drawing.Size(90, 23);
            this.alt_install_btn.TabIndex = 26;
            this.alt_install_btn.Text = "Install";
            this.alt_install_btn.UseVisualStyleBackColor = true;
            this.alt_install_btn.Click += new System.EventHandler(this.alt_install_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Stress Testing";
            // 
            // stress_clb
            // 
            this.stress_clb.CheckOnClick = true;
            this.stress_clb.FormattingEnabled = true;
            this.stress_clb.Items.AddRange(new object[] {
            "blender",
            "boinc"});
            this.stress_clb.Location = new System.Drawing.Point(168, 29);
            this.stress_clb.Name = "stress_clb";
            this.stress_clb.Size = new System.Drawing.Size(156, 40);
            this.stress_clb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 23;
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
            this.betaApps_clb.Location = new System.Drawing.Point(6, 29);
            this.betaApps_clb.Name = "betaApps_clb";
            this.betaApps_clb.Size = new System.Drawing.Size(156, 184);
            this.betaApps_clb.TabIndex = 22;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(441, 318);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.debloat_btn);
            this.Controls.Add(this.av_btn);
            this.Controls.Add(this.tweak_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(457, 357);
            this.MinimumSize = new System.Drawing.Size(457, 357);
            this.Name = "MainWindow";
            this.Text = "Winstallify";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox apps_clb;
        private System.Windows.Forms.Button install_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button debloat_btn;
        private System.Windows.Forms.Button tweak_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button av_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installWingetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button alt_clear_btn;
        private System.Windows.Forms.Button alt_install_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox stress_clb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox betaApps_clb;
    }
}
