using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineStickerDownloader
{
    public partial class frmSettings : Form
    {
        private readonly settings iniFile;
        private string savePath;

        public frmSettings()
        {
            InitializeComponent();
            string iniPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini");
            iniFile = new settings(iniPath);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            iniFile.Write("Settings", "FolderPath", tbPath.Text);
            MessageBox.Show("Settings saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbPath.Text = iniFile.Read("Settings", "FolderPath");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    savePath = folderDialog.SelectedPath;
                    tbPath.Text = savePath;
                }
            }
        }

        #region ButtonCode
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void pClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }
        #endregion
    }
}
