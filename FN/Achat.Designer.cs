
namespace GuichetAutomatique.FN
{
    partial class Achat
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAchat = new System.Windows.Forms.Label();
            this.mtAchat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommerce = new System.Windows.Forms.TextBox();
            this.btAchat = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.erreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mtAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAchat
            // 
            this.labelAchat.AutoSize = true;
            this.labelAchat.Location = new System.Drawing.Point(315, 38);
            this.labelAchat.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.labelAchat.Name = "labelAchat";
            this.labelAchat.Size = new System.Drawing.Size(317, 25);
            this.labelAchat.TabIndex = 2;
            this.labelAchat.Text = "Veuillez entrer le montant de l\'achat";
            // 
            // mtAchat
            // 
            this.mtAchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtAchat.DecimalPlaces = 2;
            this.mtAchat.Font = new System.Drawing.Font("Ebrima", 20F);
            this.mtAchat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mtAchat.Location = new System.Drawing.Point(320, 102);
            this.mtAchat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.mtAchat.Name = "mtAchat";
            this.mtAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtAchat.Size = new System.Drawing.Size(312, 40);
            this.mtAchat.TabIndex = 3;
            this.mtAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtAchat.Validated += new System.EventHandler(this.mtAchat_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veuillez entrer le nom du commerce";
            // 
            // txtCommerce
            // 
            this.txtCommerce.Location = new System.Drawing.Point(320, 267);
            this.txtCommerce.MaxLength = 50;
            this.txtCommerce.Name = "txtCommerce";
            this.txtCommerce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCommerce.Size = new System.Drawing.Size(312, 33);
            this.txtCommerce.TabIndex = 5;
            this.txtCommerce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCommerce.TextChanged += new System.EventHandler(this.txtCommerce_TextChanged);
            this.txtCommerce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommerce_KeyPress);
            // 
            // btAchat
            // 
            this.btAchat.BackColor = System.Drawing.Color.Green;
            this.btAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAchat.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.btAchat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAchat.Location = new System.Drawing.Point(474, 376);
            this.btAchat.Name = "btAchat";
            this.btAchat.Size = new System.Drawing.Size(158, 87);
            this.btAchat.TabIndex = 6;
            this.btAchat.Text = "Acheter";
            this.btAchat.UseVisualStyleBackColor = false;
            this.btAchat.Click += new System.EventHandler(this.btAchat_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.Red;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.btAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAnnuler.Location = new System.Drawing.Point(320, 376);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(148, 87);
            this.btAnnuler.TabIndex = 7;
            this.btAnnuler.Text = "Effacer";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Image = global::GuichetAutomatique.Properties.Resources.Quit;
            this.btClose.Location = new System.Drawing.Point(946, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(38, 44);
            this.btClose.TabIndex = 8;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(320, 307);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(35, 13);
            this.erreur.TabIndex = 9;
            this.erreur.Text = "label2";
            // 
            // Achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btAchat);
            this.Controls.Add(this.txtCommerce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtAchat);
            this.Controls.Add(this.labelAchat);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Achat";
            this.Size = new System.Drawing.Size(984, 535);
            ((System.ComponentModel.ISupportInitialize)(this.mtAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAchat;
        private System.Windows.Forms.NumericUpDown mtAchat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommerce;
        private System.Windows.Forms.Button btAchat;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.Label erreur;
    }
}
