using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DS2_connexion_BD_
{
    public partial class frmjobs : Form
    { SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F0UKO03\SQLEXPRESS; initial catalog = HR; Integrated security=true;");
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        SqlCommandBuilder scb;
        public frmjobs()
        {
            BindingSource bs = new BindingSource();
            InitializeComponent();
        }

        private void frmjobs_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from JOBS", conn);
             da = new SqlDataAdapter(cmd);
             ds = new DataSet();
            da.Fill(ds,"JOBS");
             bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "JOBS";
            scb = new SqlCommandBuilder(da);
            TXTID.DataBindings.Add("text", bs, "Job_ID");
            TXTTITLE.DataBindings.Add("text", bs, "Job_title");
            dgvjobs.DataSource = bs;
            conn.Close();
        }

        private void btnfst_Click(object sender, EventArgs e)
        {
           
            bs.MoveFirst();
        }

        private void btnprs_Click(object sender, EventArgs e)
        {
           
            bs.MovePrevious();
        }

        private void btnnxt_Click(object sender, EventArgs e)
        {
            
            bs.MoveNext();
        }

        private void btnlst_Click(object sender, EventArgs e)
        {
            
            bs.MoveLast();
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            TXTID.Clear();
            TXTTITLE.Clear();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try{
                bs.EndEdit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK, MessageBoxIcon.Warning);          
            }
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            da.Update(ds.Tables["JOBS"]);
        }

        private void frmjobs_FormClosed(object sender, FormClosedEventArgs e)
        {
           DialogResult res =  MessageBox.Show("save changes","closing form",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                da.Update(ds.Tables["JOBS"]);
            else
                this.Close();
            
        }
    }
}
