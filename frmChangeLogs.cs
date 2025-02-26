using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineStickerDownloader
{
    public partial class frmChangeLogs : Form
    {
        public frmChangeLogs()
        {
            InitializeComponent();
        }

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
    }
}
