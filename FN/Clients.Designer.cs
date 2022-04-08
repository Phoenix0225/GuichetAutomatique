
namespace GuichetAutomatique.FN
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFermer = new System.Windows.Forms.PictureBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckAdmin = new System.Windows.Forms.CheckBox();
            this.cbForfait = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCarte = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskNip = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFermer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbFermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guichet automatique | Ajout de clients";
            // 
            // pbFermer
            // 
            this.pbFermer.Image = global::GuichetAutomatique.Properties.Resources.Quit;
            this.pbFermer.Location = new System.Drawing.Point(500, 3);
            this.pbFermer.Name = "pbFermer";
            this.pbFermer.Size = new System.Drawing.Size(37, 38);
            this.pbFermer.TabIndex = 1;
            this.pbFermer.TabStop = false;
            this.pbFermer.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(153, 69);
            this.tbNom.MaxLength = 100;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(318, 33);
            this.tbNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom ";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(153, 142);
            this.tbPrenom.MaxLength = 100;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(318, 33);
            this.tbPrenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom ";
            // 
            // ckAdmin
            // 
            this.ckAdmin.AutoSize = true;
            this.ckAdmin.ForeColor = System.Drawing.Color.White;
            this.ckAdmin.Location = new System.Drawing.Point(153, 211);
            this.ckAdmin.Name = "ckAdmin";
            this.ckAdmin.Size = new System.Drawing.Size(156, 29);
            this.ckAdmin.TabIndex = 7;
            this.ckAdmin.Text = "Administrateur";
            this.ckAdmin.UseVisualStyleBackColor = true;
            // 
            // cbForfait
            // 
            this.cbForfait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForfait.FormattingEnabled = true;
            this.cbForfait.Location = new System.Drawing.Point(153, 275);
            this.cbForfait.Name = "cbForfait";
            this.cbForfait.Size = new System.Drawing.Size(318, 33);
            this.cbForfait.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forfait";
            // 
            // mskCarte
            // 
            this.mskCarte.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCarte.Location = new System.Drawing.Point(153, 348);
            this.mskCarte.Mask = "000 000 000";
            this.mskCarte.Name = "mskCarte";
            this.mskCarte.Size = new System.Drawing.Size(318, 33);
            this.mskCarte.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Carte";
            // 
            // mskNip
            // 
            this.mskNip.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNip.Location = new System.Drawing.Point(153, 409);
            this.mskNip.Mask = "00000";
            this.mskNip.Name = "mskNip";
            this.mskNip.PasswordChar = '*';
            this.mskNip.Size = new System.Drawing.Size(106, 33);
            this.mskNip.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "NIP";
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.Silver;
            this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistrer.Location = new System.Drawing.Point(69, 490);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(146, 44);
            this.btEnregistrer.TabIndex = 14;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            this.btEnregistrer.Click += new System.EventHandler(this.BtEnregistrer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.Silver;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Location = new System.Drawing.Point(325, 490);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(146, 44);
            this.btAnnuler.TabIndex = 15;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.BtAnnuler_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(544, 562);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskNip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbForfait);
            this.Controls.Add(this.ckAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFermer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFermer;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckAdmin;
        private System.Windows.Forms.ComboBox cbForfait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCarte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskNip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btAnnuler;
    }
}