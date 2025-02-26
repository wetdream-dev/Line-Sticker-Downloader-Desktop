using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace LineStickerDownloader
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        #region Label Button
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }

        private void pClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void pClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }
        #endregion
    }
}
