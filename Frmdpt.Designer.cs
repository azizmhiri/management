namespace DS2_connexion_BD_
{
    partial class Frmdpt
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
            this.list_dpt = new System.Windows.Forms.DataGridView();
            this.btnfst = new System.Windows.Forms.Button();
            this.btnprs = new System.Windows.Forms.Button();
            this.btnnxt = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdptname = new System.Windows.Forms.TextBox();
            this.maskedTextBox2lctid = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1depid = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnvalidate = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_dpt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_dpt
            // 
            this.list_dpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dpt.Location = new System.Drawing.Point(12, 12);
            this.list_dpt.Name = "list_dpt";
            this.list_dpt.RowHeadersWidth = 51;
            this.list_dpt.RowTemplate.Height = 24;
            this.list_dpt.Size = new System.Drawing.Size(437, 256);
            this.list_dpt.TabIndex = 1;
            // 
            // btnfst
            // 
            this.btnfst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfst.Location = new System.Drawing.Point(12, 283);
            this.btnfst.Name = "btnfst";
            this.btnfst.Size = new System.Drawing.Size(75, 29);
            this.btnfst.TabIndex = 2;
            this.btnfst.Text = "First";
            this.btnfst.UseVisualStyleBackColor = false;
            this.btnfst.Click += new System.EventHandler(this.btnfst_Click);
            // 
            // btnprs
            // 
            this.btnprs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnprs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprs.Location = new System.Drawing.Point(125, 283);
            this.btnprs.Name = "btnprs";
            this.btnprs.Size = new System.Drawing.Size(75, 29);
            this.btnprs.TabIndex = 3;
            this.btnprs.Text = "Previous";
            this.btnprs.UseVisualStyleBackColor = false;
            this.btnprs.Click += new System.EventHandler(this.btnprs_Click);
            // 
            // btnnxt
            // 
            this.btnnxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnxt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnxt.Location = new System.Drawing.Point(240, 283);
            this.btnnxt.Name = "btnnxt";
            this.btnnxt.Size = new System.Drawing.Size(75, 29);
            this.btnnxt.TabIndex = 4;
            this.btnnxt.Text = "Next";
            this.btnnxt.UseVisualStyleBackColor = false;
            this.btnnxt.Click += new System.EventHandler(this.btnnxt_Click);
            // 
            // btnlst
            // 
            this.btnlst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlst.Location = new System.Drawing.Point(356, 283);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(75, 29);
            this.btnlst.TabIndex = 5;
            this.btnlst.Text = "Last";
            this.btnlst.UseVisualStyleBackColor = false;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdptname);
            this.groupBox1.Controls.Add(this.maskedTextBox2lctid);
            this.groupBox1.Controls.Add(this.maskedTextBox1depid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(477, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departement";
            // 
            // txtdptname
            // 
            this.txtdptname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdptname.Location = new System.Drawing.Point(89, 76);
            this.txtdptname.Name = "txtdptname";
            this.txtdptname.Size = new System.Drawing.Size(168, 26);
            this.txtdptname.TabIndex = 7;
            // 
            // maskedTextBox2lctid
            // 
            this.maskedTextBox2lctid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2lctid.Location = new System.Drawing.Point(89, 107);
            this.maskedTextBox2lctid.Mask = "9999";
            this.maskedTextBox2lctid.Name = "maskedTextBox2lctid";
            this.maskedTextBox2lctid.Size = new System.Drawing.Size(168, 26);
            this.maskedTextBox2lctid.TabIndex = 8;
            this.maskedTextBox2lctid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2lctid_MaskInputRejected);
            // 
            // maskedTextBox1depid
            // 
            this.maskedTextBox1depid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1depid.Location = new System.Drawing.Point(89, 36);
            this.maskedTextBox1depid.Mask = "9999";
            this.maskedTextBox1depid.Name = "maskedTextBox1depid";
            this.maskedTextBox1depid.Size = new System.Drawing.Size(168, 26);
            this.maskedTextBox1depid.TabIndex = 6;
            this.maskedTextBox1depid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1depid_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(475, 242);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 26);
            this.btnnew.TabIndex = 9;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(566, 242);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 26);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(665, 242);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 26);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnvalidate
            // 
            this.btnvalidate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnvalidate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidate.Location = new System.Drawing.Point(514, 283);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(75, 29);
            this.btnvalidate.TabIndex = 12;
            this.btnvalidate.Text = "Validate";
            this.btnvalidate.UseVisualStyleBackColor = false;
            this.btnvalidate.Click += new System.EventHandler(this.btnvalidate_Click);
            // 
            // btnundo
            // 
            this.btnundo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnundo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnundo.Location = new System.Drawing.Point(620, 283);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 29);
            this.btnundo.TabIndex = 13;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = false;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // Frmdpt
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
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.btnnxt);
            this.Controls.Add(this.btnprs);
            this.Controls.Add(this.btnfst);
            this.Controls.Add(this.list_dpt);
            this.Name = "Frmdpt";
            this.Text = "Departements Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmdpt_FormClosed);
            this.Load += new System.EventHandler(this.Frmdpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_dpt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list_dpt;
        private System.Windows.Forms.Button btnfst;
        private System.Windows.Forms.Button btnprs;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.Button btnlst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdptname;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2lctid;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1depid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.Button btnundo;
    }
}