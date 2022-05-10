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
    public partial class AlternateApps : Form
    {
        public AlternateApps()
        {
            InitializeComponent();
        }

        private void install_btn_Click(object sender, EventArgs e)
        {
            String toInstall = "";
            for (int i = 0; i < betaApps_clb.CheckedItems.Count; i++)
            {
                toInstall = toInstall + " " + betaApps_clb.CheckedItems[i].ToString();
            }
            for (int i = 0; i < stress_clb.CheckedItems.Count; i++)
            {
                toInstall = toInstall + " " + stress_clb.CheckedItems[i].ToString();
            }
            System.Diagnostics.Process.Start("powershell.exe", "-ExecutionPolicy Bypass .\\PSScripts\\download.ps1 " + toInstall);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < betaApps_clb.Items.Count; i++)
            {
                betaApps_clb.SetItemChecked(i, false);
            }
            for (int i = 0; i < stress_clb.Items.Count; i++)
            {
                stress_clb.SetItemChecked(i, false);
            }
        }
    }
}
