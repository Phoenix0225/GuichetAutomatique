
namespace GuichetAutomatique
{
    partial class GuichetAutomatique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuichetAutomatique));
            this.lAjoutClient = new System.Windows.Forms.LinkLabel();
            this.lAchat = new System.Windows.Forms.LinkLabel();
            this.lRetrait = new System.Windows.Forms.LinkLabel();
            this.lDepotArgent = new System.Windows.Forms.LinkLabel();
            this.lDepotCheque = new System.Windows.Forms.LinkLabel();
            this.lDateJour = new System.Windows.Forms.Label();
            this.lBonjourNom = new System.Windows.Forms.Label();
            this.pBorder = new System.Windows.Forms.Panel();
            this.lTitre = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.pNavbar = new System.Windows.Forms.Panel();
            this.lbSolde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.lDeconnection = new System.Windows.Forms.LinkLabel();
            this.pTransactions = new System.Windows.Forms.Panel();
            this.pnTransactions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pLabelsTransactions = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lMontant = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lCategorie = new System.Windows.Forms.Label();
            this.lDernieresTransactions = new System.Windows.Forms.Label();
            this.pBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.pNavbar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pTransactions.SuspendLayout();
            this.pnTransactions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pLabelsTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lAjoutClient
            // 
            this.lAjoutClient.AutoSize = true;
            this.lAjoutClient.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold);
            this.lAjoutClient.LinkColor = System.Drawing.Color.Red;
            this.lAjoutClient.Location = new System.Drawing.Point(843, 14);
            this.lAjoutClient.Name = "lAjoutClient";
            this.lAjoutClient.Size = new System.Drawing.Size(210, 32);
            this.lAjoutClient.TabIndex = 24;
            this.lAjoutClient.TabStop = true;
            this.lAjoutClient.Text = "Ajout d\'un Client";
            this.lAjoutClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LAjoutClient_LinkClicked);
            // 
            // lAchat
            // 
            this.lAchat.AutoSize = true;
            this.lAchat.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAchat.LinkColor = System.Drawing.Color.Green;
            this.lAchat.Location = new System.Drawing.Point(532, 14);
            this.lAchat.Name = "lAchat";
            this.lAchat.Size = new System.Drawing.Size(80, 32);
            this.lAchat.TabIndex = 23;
            this.lAchat.TabStop = true;
            this.lAchat.Text = "Achat";
            this.lAchat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lAchat_LinkClicked);
            // 
            // lRetrait
            // 
            this.lRetrait.AutoSize = true;
            this.lRetrait.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRetrait.LinkColor = System.Drawing.Color.Green;
            this.lRetrait.Location = new System.Drawing.Point(415, 14);
            this.lRetrait.Name = "lRetrait";
            this.lRetrait.Size = new System.Drawing.Size(92, 32);
            this.lRetrait.TabIndex = 22;
            this.lRetrait.TabStop = true;
            this.lRetrait.Text = "Retrait";
            this.lRetrait.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lRetrait_LinkClicked);
            // 
            // lDepotArgent
            // 
            this.lDepotArgent.AutoSize = true;
            this.lDepotArgent.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDepotArgent.LinkColor = System.Drawing.Color.Green;
            this.lDepotArgent.Location = new System.Drawing.Point(220, 14);
            this.lDepotArgent.Name = "lDepotArgent";
            this.lDepotArgent.Size = new System.Drawing.Size(167, 32);
            this.lDepotArgent.TabIndex = 21;
            this.lDepotArgent.TabStop = true;
            this.lDepotArgent.Text = "Dépot argent";
            this.lDepotArgent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lDepotArgent_LinkClicked);
            // 
            // lDepotCheque
            // 
            this.lDepotCheque.AutoSize = true;
            this.lDepotCheque.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDepotCheque.LinkColor = System.Drawing.Color.Green;
            this.lDepotCheque.Location = new System.Drawing.Point(29, 14);
            this.lDepotCheque.Name = "lDepotCheque";
            this.lDepotCheque.Size = new System.Drawing.Size(174, 32);
            this.lDepotCheque.TabIndex = 20;
            this.lDepotCheque.TabStop = true;
            this.lDepotCheque.Text = "Dépot chèque";
            this.lDepotCheque.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lDepotCheque_LinkClicked);
            // 
            // lDateJour
            // 
            this.lDateJour.AutoSize = true;
            this.lDateJour.ForeColor = System.Drawing.Color.White;
            this.lDateJour.Location = new System.Drawing.Point(1092, 33);
            this.lDateJour.Name = "lDateJour";
            this.lDateJour.Size = new System.Drawing.Size(117, 25);
            this.lDateJour.TabIndex = 19;
            this.lDateJour.Text = "Date du jour";
            // 
            // lBonjourNom
            // 
            this.lBonjourNom.AutoSize = true;
            this.lBonjourNom.ForeColor = System.Drawing.Color.White;
            this.lBonjourNom.Location = new System.Drawing.Point(12, 13);
            this.lBonjourNom.Name = "lBonjourNom";
            this.lBonjourNom.Size = new System.Drawing.Size(79, 25);
            this.lBonjourNom.TabIndex = 18;
            this.lBonjourNom.Text = "Bonjour";
            // 
            // pBorder
            // 
            this.pBorder.Controls.Add(this.lTitre);
            this.pBorder.Controls.Add(this.btClose);
            this.pBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBorder.Location = new System.Drawing.Point(0, 0);
            this.pBorder.Name = "pBorder";
            this.pBorder.Size = new System.Drawing.Size(1245, 44);
            this.pBorder.TabIndex = 17;
            this.pBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBorder_MouseDown);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.ForeColor = System.Drawing.Color.White;
            this.lTitre.Location = new System.Drawing.Point(12, 9);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(191, 25);
            this.lTitre.TabIndex = 2;
            this.lTitre.Text = "Guichet Automatique";
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Image = global::GuichetAutomatique.Properties.Resources.Quit;
            this.btClose.Location = new System.Drawing.Point(1206, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(39, 44);
            this.btClose.TabIndex = 1;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // pNavbar
            // 
            this.pNavbar.Controls.Add(this.lbSolde);
            this.pNavbar.Controls.Add(this.label1);
            this.pNavbar.Controls.Add(this.lBonjourNom);
            this.pNavbar.Controls.Add(this.lDateJour);
            this.pNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavbar.Location = new System.Drawing.Point(0, 44);
            this.pNavbar.Name = "pNavbar";
            this.pNavbar.Size = new System.Drawing.Size(1245, 84);
            this.pNavbar.TabIndex = 25;
            // 
            // lbSolde
            // 
            this.lbSolde.AutoSize = true;
            this.lbSolde.ForeColor = System.Drawing.Color.White;
            this.lbSolde.Location = new System.Drawing.Point(308, 47);
            this.lbSolde.Name = "lbSolde";
            this.lbSolde.Size = new System.Drawing.Size(46, 25);
            this.lbSolde.TabIndex = 21;
            this.lbSolde.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Le solde de votre compte est de :";
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lDeconnection);
            this.pMain.Controls.Add(this.pTransactions);
            this.pMain.Controls.Add(this.lAjoutClient);
            this.pMain.Controls.Add(this.lDernieresTransactions);
            this.pMain.Controls.Add(this.lDepotArgent);
            this.pMain.Controls.Add(this.lDepotCheque);
            this.pMain.Controls.Add(this.lAchat);
            this.pMain.Controls.Add(this.lRetrait);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 128);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1245, 581);
            this.pMain.TabIndex = 25;
            // 
            // lDeconnection
            // 
            this.lDeconnection.AutoSize = true;
            this.lDeconnection.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeconnection.LinkColor = System.Drawing.Color.Green;
            this.lDeconnection.Location = new System.Drawing.Point(1059, 14);
            this.lDeconnection.Name = "lDeconnection";
            this.lDeconnection.Size = new System.Drawing.Size(174, 32);
            this.lDeconnection.TabIndex = 25;
            this.lDeconnection.TabStop = true;
            this.lDeconnection.Text = "Déconnection";
            this.lDeconnection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lDeconnection_LinkClicked);
            // 
            // pTransactions
            // 
            this.pTransactions.Controls.Add(this.pnTransactions);
            this.pTransactions.Controls.Add(this.pLabelsTransactions);
            this.pTransactions.Location = new System.Drawing.Point(166, 142);
            this.pTransactions.Name = "pTransactions";
            this.pTransactions.Size = new System.Drawing.Size(918, 427);
            this.pTransactions.TabIndex = 20;
            // 
            // pnTransactions
            // 
            this.pnTransactions.Controls.Add(this.panel1);
            this.pnTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTransactions.Location = new System.Drawing.Point(0, 49);
            this.pnTransactions.Name = "pnTransactions";
            this.pnTransactions.Size = new System.Drawing.Size(918, 378);
            this.pnTransactions.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 76);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(800, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Frais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(619, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(230, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Catégorie de la transaction qui a été fait";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date";
            // 
            // pLabelsTransactions
            // 
            this.pLabelsTransactions.Controls.Add(this.label5);
            this.pLabelsTransactions.Controls.Add(this.lMontant);
            this.pLabelsTransactions.Controls.Add(this.lDate);
            this.pLabelsTransactions.Controls.Add(this.lCategorie);
            this.pLabelsTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLabelsTransactions.Location = new System.Drawing.Point(0, 0);
            this.pLabelsTransactions.Name = "pLabelsTransactions";
            this.pLabelsTransactions.Size = new System.Drawing.Size(918, 49);
            this.pLabelsTransactions.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(800, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Frais";
            // 
            // lMontant
            // 
            this.lMontant.AutoSize = true;
            this.lMontant.ForeColor = System.Drawing.Color.White;
            this.lMontant.Location = new System.Drawing.Point(619, 12);
            this.lMontant.Name = "lMontant";
            this.lMontant.Size = new System.Drawing.Size(84, 25);
            this.lMontant.TabIndex = 17;
            this.lMontant.Text = "Montant";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.ForeColor = System.Drawing.Color.White;
            this.lDate.Location = new System.Drawing.Point(33, 12);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(51, 25);
            this.lDate.TabIndex = 15;
            this.lDate.Text = "Date";
            // 
            // lCategorie
            // 
            this.lCategorie.AutoSize = true;
            this.lCategorie.ForeColor = System.Drawing.Color.White;
            this.lCategorie.Location = new System.Drawing.Point(230, 12);
            this.lCategorie.Name = "lCategorie";
            this.lCategorie.Size = new System.Drawing.Size(108, 25);
            this.lCategorie.TabIndex = 16;
            this.lCategorie.Text = "Description";
            // 
            // lDernieresTransactions
            // 
            this.lDernieresTransactions.AutoSize = true;
            this.lDernieresTransactions.ForeColor = System.Drawing.Color.White;
            this.lDernieresTransactions.Location = new System.Drawing.Point(161, 101);
            this.lDernieresTransactions.Name = "lDernieresTransactions";
            this.lDernieresTransactions.Size = new System.Drawing.Size(209, 25);
            this.lDernieresTransactions.TabIndex = 19;
            this.lDernieresTransactions.Text = "Dernières transactions :";
            // 
            // GuichetAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1245, 709);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pNavbar);
            this.Controls.Add(this.pBorder);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GuichetAutomatique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guichet Automatique";
            this.Load += new System.EventHandler(this.GuichetAutomatique_Load);
            this.pBorder.ResumeLayout(false);
            this.pBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.pNavbar.ResumeLayout(false);
            this.pNavbar.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pTransactions.ResumeLayout(false);
            this.pnTransactions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pLabelsTransactions.ResumeLayout(false);
            this.pLabelsTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lAjoutClient;
        private System.Windows.Forms.LinkLabel lAchat;
        private System.Windows.Forms.LinkLabel lRetrait;
        private System.Windows.Forms.LinkLabel lDepotArgent;
        private System.Windows.Forms.LinkLabel lDepotCheque;
        private System.Windows.Forms.Label lDateJour;
        private System.Windows.Forms.Label lBonjourNom;
        private System.Windows.Forms.Panel pBorder;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.Panel pNavbar;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pTransactions;
        private System.Windows.Forms.Panel pLabelsTransactions;
        private System.Windows.Forms.Label lMontant;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lCategorie;
        private System.Windows.Forms.Label lDernieresTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSolde;
        private System.Windows.Forms.LinkLabel lDeconnection;
        private System.Windows.Forms.Panel pnTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

