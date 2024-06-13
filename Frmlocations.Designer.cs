namespace DS2_connexion_BD_
{
    partial class Frmlocations
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
            this.dgvlocations = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1locationid = new System.Windows.Forms.MaskedTextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.btnfst = new System.Windows.Forms.Button();
            this.btnprs = new System.Windows.Forms.Button();
            this.btnnxt = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnvalidate = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvlocations
            // 
            this.dgvlocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocations.Location = new System.Drawing.Point(22, 24);
            this.dgvlocations.Name = "dgvlocations";
            this.dgvlocations.RowHeadersWidth = 51;
            this.dgvlocations.RowTemplate.Height = 24;
            this.dgvlocations.Size = new System.Drawing.Size(371, 214);
            this.dgvlocations.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.maskedTextBox1locationid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(444, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // maskedTextBox1locationid
            // 
            this.maskedTextBox1locationid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1locationid.Location = new System.Drawing.Point(105, 40);
            this.maskedTextBox1locationid.Mask = "9999";
            this.maskedTextBox1locationid.Name = "maskedTextBox1locationid";
            this.maskedTextBox1locationid.Size = new System.Drawing.Size(152, 26);
            this.maskedTextBox1locationid.TabIndex = 6;
            this.maskedTextBox1locationid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1locationid_MaskInputRejected);
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(105, 78);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(152, 26);
            this.txtlname.TabIndex = 7;
            // 
            // btnfst
            // 
            this.btnfst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfst.Location = new System.Drawing.Point(22, 244);
            this.btnfst.Name = "btnfst";
            this.btnfst.Size = new System.Drawing.Size(75, 30);
            this.btnfst.TabIndex = 2;
            this.btnfst.Text = "First";
            this.btnfst.UseVisualStyleBackColor = false;
            this.btnfst.Click += new System.EventHandler(this.btnfst_Click);
            // 
            // btnprs
            // 
            this.btnprs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnprs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprs.Location = new System.Drawing.Point(112, 244);
            this.btnprs.Name = "btnprs";
            this.btnprs.Size = new System.Drawing.Size(79, 30);
            this.btnprs.TabIndex = 3;
            this.btnprs.Text = "Previous";
            this.btnprs.UseVisualStyleBackColor = false;
            this.btnprs.Click += new System.EventHandler(this.btnprs_Click);
            // 
            // btnnxt
            // 
            this.btnnxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnxt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnxt.Location = new System.Drawing.Point(212, 244);
            this.btnnxt.Name = "btnnxt";
            this.btnnxt.Size = new System.Drawing.Size(75, 30);
            this.btnnxt.TabIndex = 4;
            this.btnnxt.Text = "Next";
            this.btnnxt.UseVisualStyleBackColor = false;
            this.btnnxt.Click += new System.EventHandler(this.btnnxt_Click);
            // 
            // btnlst
            // 
            this.btnlst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlst.Location = new System.Drawing.Point(307, 244);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(75, 30);
            this.btnlst.TabIndex = 5;
            this.btnlst.Text = "Last";
            this.btnlst.UseVisualStyleBackColor = false;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(444, 210);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 28);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(539, 210);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 28);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(639, 210);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 28);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnvalidate
            // 
            this.btnvalidate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnvalidate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidate.Location = new System.Drawing.Point(488, 244);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(75, 30);
            this.btnvalidate.TabIndex = 11;
            this.btnvalidate.Text = "Validate";
            this.btnvalidate.UseVisualStyleBackColor = false;
            this.btnvalidate.Click += new System.EventHandler(this.btnvalidate_Click);
            // 
            // btnundo
            // 
            this.btnundo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnundo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnundo.Location = new System.Drawing.Point(607, 244);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 30);
            this.btnundo.TabIndex = 12;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = false;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // Frmlocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.btnvalidate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.btnnxt);
            this.Controls.Add(this.btnprs);
            this.Controls.Add(this.btnfst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvlocations);
            this.Name = "Frmlocations";
            this.Text = "Locations Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmlocations_FormClosed);
            this.Load += new System.EventHandler(this.Frmlocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlocations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1locationid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfst;
        private System.Windows.Forms.Button btnprs;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.Button btnlst;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.Button btnundo;
    }
}