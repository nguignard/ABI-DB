using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abi
{
    public partial class FrmMDI : Form
    {

        private frmGrdClt frmlisteClient;

        public FrmMDI()
        {
            InitializeComponent();
            this.frmlisteClient = new frmGrdClt();
            this.frmlisteClient.FormClosing += new FormClosingEventHandler(this.fermeFrmGrdClt);
            this.frmlisteClient.MdiParent = this;
            this.frmlisteClient.Show();
        }

        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmlisteClient == null)
            {
                this.frmlisteClient = new frmGrdClt();
                this.frmlisteClient.MdiParent = this;
                this.frmlisteClient.Show();
            }
            else
                this.frmlisteClient.Activate();
        }

        private void fermeFrmGrdClt(object sender, FormClosingEventArgs e)
        {
            this.frmlisteClient = null;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
