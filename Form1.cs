using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS2_connexion_BD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnqt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnjbs_Click(object sender, EventArgs e)
        {
            frmjobs frm = new frmjobs();
            frm.ShowDialog();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            frmemp frm = new frmemp();
            frm.ShowDialog();
        }

        private void btndprt_Click(object sender, EventArgs e)
        {
            Frmdpt frm = new Frmdpt();
            frm.ShowDialog();
        }

        private void btnlcs_Click(object sender, EventArgs e)
        {
            Frmlocations frm = new Frmlocations();
            frm.ShowDialog();
        }
    }
}
