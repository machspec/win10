using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < apps_clb.Items.Count; i++)
            {
                apps_clb.SetItemChecked(i, false);
            }
            
        }
        

        private void otherAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlternateApps alternateApps = new AlternateApps();
            alternateApps.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void install_btn_Click(object sender, EventArgs e)
        {
            String toInstall = "";
            for (int i = 0; i < apps_clb.CheckedItems.Count; i++)
            {
                toInstall = toInstall + " " + apps_clb.CheckedItems[i].ToString();
            }
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\download.ps1 " + toInstall);
        }
        private void debloat_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\debloat.ps1");
        }

        private void tweak_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\tweaks.ps1");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\update.ps1");
        }

        private void av_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\av.ps1");
        }

        private void installWingetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\winget.ps1");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
