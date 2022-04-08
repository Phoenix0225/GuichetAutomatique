
namespace GuichetAutomatique.FN
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbQuit = new System.Windows.Forms.PictureBox();
            this.mskCarte = new System.Windows.Forms.MaskedTextBox();
            this.mskNip = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btEntrer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guichet automatique | Connexion";
            // 
            // pbQuit
            // 
            this.pbQuit.Image = global::GuichetAutomatique.Properties.Resources.Quit;
            this.pbQuit.Location = new System.Drawing.Point(563, 3);
            this.pbQuit.Name = "pbQuit";
            this.pbQuit.Size = new System.Drawing.Size(37, 38);
            this.pbQuit.TabIndex = 1;
            this.pbQuit.TabStop = false;
            this.pbQuit.Click += new System.EventHandler(this.PbQuit_Click);
            // 
            // mskCarte
            // 
            this.mskCarte.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCarte.Location = new System.Drawing.Point(128, 125);
            this.mskCarte.Mask = "000 000 000";
            this.mskCarte.Name = "mskCarte";
            this.mskCarte.Size = new System.Drawing.Size(335, 48);
            this.mskCarte.TabIndex = 3;
            // 
            // mskNip
            // 
            this.mskNip.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNip.Location = new System.Drawing.Point(128, 235);
            this.mskNip.Mask = "00000";
            this.mskNip.Name = "mskNip";
            this.mskNip.PasswordChar = '*';
            this.mskNip.Size = new System.Drawing.Size(335, 48);
            this.mskNip.TabIndex = 4;
            this.mskNip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskNip_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numéro de la carte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "NIP";
            // 
            // btEntrer
            // 
            this.btEntrer.BackColor = System.Drawing.Color.Silver;
            this.btEntrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrer.Location = new System.Drawing.Point(128, 333);
            this.btEntrer.Name = "btEntrer";
            this.btEntrer.Size = new System.Drawing.Size(146, 44);
            this.btEntrer.TabIndex = 7;
            this.btEntrer.Text = "Entrer";
            this.btEntrer.UseVisualStyleBackColor = false;
            this.btEntrer.Click += new System.EventHandler(this.btEntrer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.Silver;
            this.btQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuitter.Location = new System.Drawing.Point(317, 333);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(146, 44);
            this.btQuitter.TabIndex = 8;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(608, 435);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEntrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskNip);
            this.Controls.Add(this.mskCarte);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQuit;
        private System.Windows.Forms.MaskedTextBox mskCarte;
        private System.Windows.Forms.MaskedTextBox mskNip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEntrer;
        private System.Windows.Forms.Button btQuitter;
    }
}