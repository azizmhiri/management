namespace DS2_connexion_BD_
{
    partial class frmjobs
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
            this.dgvjobs = new System.Windows.Forms.DataGridView();
            this.btnfst = new System.Windows.Forms.Button();
            this.btnprs = new System.Windows.Forms.Button();
            this.btnnxt = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.grpbxjob = new System.Windows.Forms.GroupBox();
            this.TXTTITLE = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnvalidate = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjobs)).BeginInit();
            this.grpbxjob.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvjobs
            // 
            this.dgvjobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjobs.Location = new System.Drawing.Point(12, 12);
            this.dgvjobs.Name = "dgvjobs";
            this.dgvjobs.RowHeadersWidth = 51;
            this.dgvjobs.RowTemplate.Height = 24;
            this.dgvjobs.Size = new System.Drawing.Size(436, 300);
            this.dgvjobs.TabIndex = 1;
            // 
            // btnfst
            // 
            this.btnfst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnfst.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfst.Location = new System.Drawing.Point(35, 318);
            this.btnfst.Name = "btnfst";
            this.btnfst.Size = new System.Drawing.Size(75, 31);
            this.btnfst.TabIndex = 2;
            this.btnfst.Text = "First";
            this.btnfst.UseVisualStyleBackColor = false;
            this.btnfst.Click += new System.EventHandler(this.btnfst_Click);
            // 
            // btnprs
            // 
            this.btnprs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnprs.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprs.Location = new System.Drawing.Point(152, 318);
            this.btnprs.Name = "btnprs";
            this.btnprs.Size = new System.Drawing.Size(75, 31);
            this.btnprs.TabIndex = 3;
            this.btnprs.Text = "previous";
            this.btnprs.UseVisualStyleBackColor = false;
            this.btnprs.Click += new System.EventHandler(this.btnprs_Click);
            // 
            // btnnxt
            // 
            this.btnnxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnxt.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnxt.Location = new System.Drawing.Point(258, 318);
            this.btnnxt.Name = "btnnxt";
            this.btnnxt.Size = new System.Drawing.Size(75, 31);
            this.btnnxt.TabIndex = 4;
            this.btnnxt.Text = "Next";
            this.btnnxt.UseVisualStyleBackColor = false;
            this.btnnxt.Click += new System.EventHandler(this.btnnxt_Click);
            // 
            // btnlst
            // 
            this.btnlst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlst.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlst.Location = new System.Drawing.Point(353, 318);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(75, 31);
            this.btnlst.TabIndex = 5;
            this.btnlst.Text = "Last";
            this.btnlst.UseVisualStyleBackColor = false;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // grpbxjob
            // 
            this.grpbxjob.Controls.Add(this.TXTTITLE);
            this.grpbxjob.Controls.Add(this.TXTID);
            this.grpbxjob.Controls.Add(this.label2);
            this.grpbxjob.Controls.Add(this.label1);
            this.grpbxjob.Location = new System.Drawing.Point(502, 97);
            this.grpbxjob.Name = "grpbxjob";
            this.grpbxjob.Size = new System.Drawing.Size(224, 100);
            this.grpbxjob.TabIndex = 5;
            this.grpbxjob.TabStop = false;
            this.grpbxjob.Text = "job";
            // 
            // TXTTITLE
            // 
            this.TXTTITLE.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTITLE.Location = new System.Drawing.Point(59, 58);
            this.TXTTITLE.Name = "TXTTITLE";
            this.TXTTITLE.Size = new System.Drawing.Size(159, 26);
            this.TXTTITLE.TabIndex = 7;
            // 
            // TXTID
            // 
            this.TXTID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(59, 22);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(159, 26);
            this.TXTID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(489, 203);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 33);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(570, 203);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(651, 203);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 33);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnvalidate
            // 
            this.btnvalidate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnvalidate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidate.Location = new System.Drawing.Point(526, 242);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(75, 31);
            this.btnvalidate.TabIndex = 11;
            this.btnvalidate.Text = "Validate";
            this.btnvalidate.UseVisualStyleBackColor = false;
            this.btnvalidate.Click += new System.EventHandler(this.btnvalidate_Click);
            // 
            // btnundo
            // 
            this.btnundo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnundo.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnundo.Location = new System.Drawing.Point(617, 242);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 31);
            this.btnundo.TabIndex = 12;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = false;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // frmjobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnvalidate);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.grpbxjob);
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.btnnxt);
            this.Controls.Add(this.btnprs);
            this.Controls.Add(this.btnfst);
            this.Controls.Add(this.dgvjobs);
            this.Name = "frmjobs";
            this.Text = "Jobs management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmjobs_FormClosed);
            this.Load += new System.EventHandler(this.frmjobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjobs)).EndInit();
            this.grpbxjob.ResumeLayout(false);
            this.grpbxjob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvjobs;
        private System.Windows.Forms.Button btnfst;
        private System.Windows.Forms.Button btnprs;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.Button btnlst;
        private System.Windows.Forms.GroupBox grpbxjob;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.Button btnundo;
        private System.Windows.Forms.TextBox TXTTITLE;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}