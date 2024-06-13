namespace DS2_connexion_BD_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnemp = new System.Windows.Forms.Button();
            this.btnjbs = new System.Windows.Forms.Button();
            this.btndprt = new System.Windows.Forms.Button();
            this.btnlcs = new System.Windows.Forms.Button();
            this.btnqt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnemp.Location = new System.Drawing.Point(140, 77);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(219, 38);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "Employees";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnjbs
            // 
            this.btnjbs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnjbs.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjbs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnjbs.Location = new System.Drawing.Point(376, 77);
            this.btnjbs.Name = "btnjbs";
            this.btnjbs.Size = new System.Drawing.Size(239, 38);
            this.btnjbs.TabIndex = 2;
            this.btnjbs.Text = "jobs";
            this.btnjbs.UseVisualStyleBackColor = false;
            this.btnjbs.Click += new System.EventHandler(this.btnjbs_Click);
            // 
            // btndprt
            // 
            this.btndprt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndprt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndprt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndprt.Location = new System.Drawing.Point(140, 165);
            this.btndprt.Name = "btndprt";
            this.btndprt.Size = new System.Drawing.Size(219, 37);
            this.btndprt.TabIndex = 3;
            this.btndprt.Text = "Departements";
            this.btndprt.UseVisualStyleBackColor = false;
            this.btndprt.Click += new System.EventHandler(this.btndprt_Click);
            // 
            // btnlcs
            // 
            this.btnlcs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlcs.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlcs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlcs.Location = new System.Drawing.Point(376, 165);
            this.btnlcs.Name = "btnlcs";
            this.btnlcs.Size = new System.Drawing.Size(239, 37);
            this.btnlcs.TabIndex = 4;
            this.btnlcs.Text = "Locations";
            this.btnlcs.UseVisualStyleBackColor = false;
            this.btnlcs.Click += new System.EventHandler(this.btnlcs_Click);
            // 
            // btnqt
            // 
            this.btnqt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnqt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqt.Location = new System.Drawing.Point(140, 233);
            this.btnqt.Name = "btnqt";
            this.btnqt.Size = new System.Drawing.Size(475, 38);
            this.btnqt.TabIndex = 5;
            this.btnqt.Text = "Quit";
            this.btnqt.UseVisualStyleBackColor = false;
            this.btnqt.Click += new System.EventHandler(this.btnqt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btnqt);
            this.Controls.Add(this.btnlcs);
            this.Controls.Add(this.btndprt);
            this.Controls.Add(this.btnjbs);
            this.Controls.Add(this.btnemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btnjbs;
        private System.Windows.Forms.Button btndprt;
        private System.Windows.Forms.Button btnlcs;
        private System.Windows.Forms.Button btnqt;
    }
}

