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
    /// <summary>
    /// Class pour visualiser les documents des contacts, non implemente au 2017.04.10
    /// </summary>
    public partial class frmDspDocIntervenant : Form
    {
        public frmDspDocIntervenant()
        {
            InitializeComponent();
        }

        private void frmDspDocIntervenant_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

    }
}
