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
    public partial class frmemp : Form
    {
        SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F0UKO03\SQLEXPRESS; initial catalog = HR; Integrated security=true;");
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        SqlCommandBuilder scb;
        
        public frmemp()
        {
            BindingSource bs = new BindingSource();
            InitializeComponent();
        }

        private void frmemp_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from EMPLOYEES",conn);
            da= new SqlDataAdapter(cmd);
            ds= new DataSet();
            da.Fill(ds, "EMPLOYEES");
            bs= new BindingSource();
            bs.DataSource=ds;
            bs.DataMember = "EMPLOYEES";
            scb = new SqlCommandBuilder(da);
            listBoxemp.DataSource=bs;
            listBoxemp.ValueMember = "Employee_Id";
            listBoxemp.DisplayMember = "First_name";
            maskedTextBoxempid.DataBindings.Add("text", bs, "Employee_Id");
            txtfstn.DataBindings.Add("text", bs, "First_name");
            txtlstn.DataBindings.Add("text", bs, "Last_name");
            maskedTextBoxjobid.DataBindings.Add("text", bs, "Job_ID");
            maskedTextBoxdptid.DataBindings.Add("text", bs, "Departement_ID");
            dateTimePicker1.DataBindings.Add("text", bs, "Hire_date");
            conn.Close();
            


        }

        private void maskedTextBoxempid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Try a number","Invalid Data Type",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

    

        private void maskedTextBoxdptid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Try a number", "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Hire date can't be greater then" + DateTime.Now, "Invalid Data Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void maskedTextBoxjobid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Try a letter", "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
        }

        private void btnnew_Click(object sender, EventArgs e)
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
            da.Update(ds.Tables["EMPLOYEES"]);
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            maskedTextBoxempid.Clear();
            txtfstn.Clear();
            txtlstn.Clear();
            maskedTextBoxjobid.Clear();
            dateTimePicker1.ResetText();
            maskedTextBoxdptid.Clear();
        }

        private void frmemp_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult res = MessageBox.Show("save changes", "closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                da.Update(ds.Tables["EMPLOYEES"]);
            else
                this.Close();
        }
    }
}
