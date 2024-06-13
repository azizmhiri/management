namespace DS2_connexion_BD_
{
    partial class frmemp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxemp = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtlstn = new System.Windows.Forms.TextBox();
            this.txtfstn = new System.Windows.Forms.TextBox();
            this.maskedTextBoxdptid = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxjobid = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxempid = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnvalidate = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxemp
            // 
            this.listBoxemp.FormattingEnabled = true;
            this.listBoxemp.ItemHeight = 16;
            this.listBoxemp.Location = new System.Drawing.Point(12, 27);
            this.listBoxemp.Name = "listBoxemp";
            this.listBoxemp.Size = new System.Drawing.Size(361, 324);
            this.listBoxemp.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtlstn);
            this.groupBox1.Controls.Add(this.txtfstn);
            this.groupBox1.Controls.Add(this.maskedTextBoxdptid);
            this.groupBox1.Controls.Add(this.maskedTextBoxjobid);
            this.groupBox1.Controls.Add(this.maskedTextBoxempid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(416, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // txtlstn
            // 
            this.txtlstn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlstn.Location = new System.Drawing.Point(121, 111);
            this.txtlstn.Name = "txtlstn";
            this.txtlstn.Size = new System.Drawing.Size(160, 26);
            this.txtlstn.TabIndex = 4;
            // 
            // txtfstn
            // 
            this.txtfstn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfstn.Location = new System.Drawing.Point(121, 75);
            this.txtfstn.Name = "txtfstn";
            this.txtfstn.Size = new System.Drawing.Size(160, 26);
            this.txtfstn.TabIndex = 3;
            // 
            // maskedTextBoxdptid
            // 
            this.maskedTextBoxdptid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxdptid.Location = new System.Drawing.Point(147, 206);
            this.maskedTextBoxdptid.Mask = "9999";
            this.maskedTextBoxdptid.Name = "maskedTextBoxdptid";
            this.maskedTextBoxdptid.Size = new System.Drawing.Size(143, 26);
            this.maskedTextBoxdptid.TabIndex = 7;
            this.maskedTextBoxdptid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxdptid_MaskInputRejected);
            // 
            // maskedTextBoxjobid
            // 
            this.maskedTextBoxjobid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxjobid.Location = new System.Drawing.Point(121, 173);
            this.maskedTextBoxjobid.Mask = "aaa";
            this.maskedTextBoxjobid.Name = "maskedTextBoxjobid";
            this.maskedTextBoxjobid.Size = new System.Drawing.Size(160, 26);
            this.maskedTextBoxjobid.TabIndex = 6;
            this.maskedTextBoxjobid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxjobid_MaskInputRejected);
            // 
            // maskedTextBoxempid
            // 
            this.maskedTextBoxempid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxempid.Location = new System.Drawing.Point(121, 43);
            this.maskedTextBoxempid.Mask = "9999";
            this.maskedTextBoxempid.Name = "maskedTextBoxempid";
            this.maskedTextBoxempid.Size = new System.Drawing.Size(160, 26);
            this.maskedTextBoxempid.TabIndex = 2;
            this.maskedTextBoxempid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxempid_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departement_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hire Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee_ID";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(416, 303);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 32);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(537, 303);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 32);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(645, 303);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 32);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnvalidate
            // 
            this.btnvalidate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnvalidate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidate.Location = new System.Drawing.Point(473, 341);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(75, 34);
            this.btnvalidate.TabIndex = 11;
            this.btnvalidate.Text = "Validate";
            this.btnvalidate.UseVisualStyleBackColor = false;
            this.btnvalidate.Click += new System.EventHandler(this.btnvalidate_Click);
            // 
            // btnundo
            // 
            this.btnundo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnundo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnundo.Location = new System.Drawing.Point(595, 341);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 34);
            this.btnundo.TabIndex = 12;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = false;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // frmemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.btnvalidate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxemp);
            this.Name = "frmemp";
            this.Text = "Employees Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmemp_FormClosed);
            this.Load += new System.EventHandler(this.frmemp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtlstn;
        private System.Windows.Forms.TextBox txtfstn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxdptid;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxjobid;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxempid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.Button btnundo;
    }
}