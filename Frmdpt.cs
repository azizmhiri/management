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
    public partial class Frmdpt : Form
    {
        SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F0UKO03\SQLEXPRESS; initial catalog = HR; Integrated security=true;");
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        SqlCommandBuilder scb;

        public Frmdpt()
        {
            BindingSource bs = new BindingSource();
            InitializeComponent();
        }

        private void Frmdpt_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from DEPARTEMENTS", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "DEPARTEMENTS");
            bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "DEPARTEMENTS";
            scb = new SqlCommandBuilder(da);
            maskedTextBox1depid.DataBindings.Add("text", bs, "Departement_ID");
            txtdptname.DataBindings.Add("text", bs, "Departement_name");
            maskedTextBox2lctid.DataBindings.Add("text", bs, "Location_ID");
            list_dpt.DataSource = bs;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            da.Update(ds.Tables["DEPARTEMENTS"]);
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            maskedTextBox1depid.Clear();
            txtdptname.Clear();
            maskedTextBox2lctid.Clear();
        }

        private void Frmdpt_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult res = MessageBox.Show("save changes", "closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                da.Update(ds.Tables["DEPARTEMENTS"]);
            else
                this.Close();
        }

        private void maskedTextBox1depid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Try a number","Invalid Data Type",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void maskedTextBox2lctid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Try a number", "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
