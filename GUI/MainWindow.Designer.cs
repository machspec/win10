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
            this.apps_clb = new System.Windows.Forms.CheckedListBox();
            this.install_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.debloat_btn = new System.Windows.Forms.Button();
            this.tweak_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.av_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installWingetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.apps_clb.Location = new System.Drawing.Point(12, 45);
            this.apps_clb.MultiColumn = true;
            this.apps_clb.Name = "apps_clb";
            this.apps_clb.Size = new System.Drawing.Size(418, 184);
            this.apps_clb.Sorted = true;
            this.apps_clb.TabIndex = 0;
            // 
            // install_btn
            // 
            this.install_btn.Location = new System.Drawing.Point(12, 235);
            this.install_btn.Name = "install_btn";
            this.install_btn.Size = new System.Drawing.Size(206, 23);
            this.install_btn.TabIndex = 1;
            this.install_btn.Text = "Install";
            this.install_btn.UseVisualStyleBackColor = true;
            this.install_btn.Click += new System.EventHandler(this.install_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(224, 235);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(206, 23);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // debloat_btn
            // 
            this.debloat_btn.Location = new System.Drawing.Point(12, 264);
            this.debloat_btn.Name = "debloat_btn";
            this.debloat_btn.Size = new System.Drawing.Size(100, 23);
            this.debloat_btn.TabIndex = 3;
            this.debloat_btn.Text = "Debloat";
            this.debloat_btn.UseVisualStyleBackColor = true;
            this.debloat_btn.Click += new System.EventHandler(this.debloat_btn_Click);
            // 
            // tweak_btn
            // 
            this.tweak_btn.Location = new System.Drawing.Point(118, 264);
            this.tweak_btn.Name = "tweak_btn";
            this.tweak_btn.Size = new System.Drawing.Size(100, 23);
            this.tweak_btn.TabIndex = 4;
            this.tweak_btn.Text = "Apply Tweaks";
            this.tweak_btn.UseVisualStyleBackColor = true;
            this.tweak_btn.Click += new System.EventHandler(this.tweak_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(224, 264);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 23);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // av_btn
            // 
            this.av_btn.Location = new System.Drawing.Point(330, 264);
            this.av_btn.Name = "av_btn";
            this.av_btn.Size = new System.Drawing.Size(100, 23);
            this.av_btn.TabIndex = 5;
            this.av_btn.Text = "Anti-Virus";
            this.av_btn.UseVisualStyleBackColor = true;
            this.av_btn.Click += new System.EventHandler(this.av_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Release Apps";
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherAppsToolStripMenuItem,
            this.installWingetToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // otherAppsToolStripMenuItem
            // 
            this.otherAppsToolStripMenuItem.Name = "otherAppsToolStripMenuItem";
            this.otherAppsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherAppsToolStripMenuItem.Text = "Other Apps";
            this.otherAppsToolStripMenuItem.Click += new System.EventHandler(this.otherAppsToolStripMenuItem_Click);
            // 
            // installWingetToolStripMenuItem
            // 
            this.installWingetToolStripMenuItem.Name = "installWingetToolStripMenuItem";
            this.installWingetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.installWingetToolStripMenuItem.Text = "Install winget";
            this.installWingetToolStripMenuItem.Click += new System.EventHandler(this.installWingetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.av_btn);
            this.Controls.Add(this.tweak_btn);
            this.Controls.Add(this.debloat_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.install_btn);
            this.Controls.Add(this.apps_clb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MSInstall";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installWingetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
