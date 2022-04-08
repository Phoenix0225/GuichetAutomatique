// *********************************************************************
// Programmeur : Francis Blanchette
// Date : 12 mars 2021
// Fichier : Clients.cs
//
// Fenêtre de création d'utilisateur
// *********************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GuichetAutomatique.FN
{
    public partial class Clients : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Clients()
        {
            InitializeComponent();

            ChargerCBForfait();
            cbForfait.SelectedIndex = 0;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur la x dans le coin droit, la fenêtre se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton enregistrer, on ajoute l'information à la base de données
        /// Et on ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEnregistrer_Click(object sender, EventArgs e)
        {
            tbNom.BackColor = Color.White;
            tbPrenom.BackColor = Color.White;
            mskCarte.BackColor = Color.White;
            mskNip.BackColor = Color.White;

            String noCarte = mskCarte.Text.Replace(" ", "");
            String nip = mskNip.Text.Replace(" ", "");

            // Valide si toutes les text box ont été complété
            if (tbNom.Text.Trim().Equals("") || tbPrenom.Text.Trim().Equals("") ||
                mskCarte.Text.Trim().Equals("") || mskNip.Text.Trim().Equals(""))
            {
                // Si une texte box est resté vide, on met la text box en rouge
                if (tbNom.Text.Trim().Equals(""))
                {
                    tbNom.BackColor = Color.LightPink;
                }
                if (tbPrenom.Text.Trim().Equals(""))
                {
                    tbPrenom.BackColor = Color.LightPink;
                }
                if (mskCarte.Text.Trim().Equals(""))
                {
                    mskCarte.BackColor = Color.LightPink;
                }
                if (mskNip.Text.Trim().Equals(""))
                {
                    mskNip.BackColor = Color.LightPink;
                }

                MessageBox.Show("Vous devez compléter tous les champs.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Valide que le numéro de carte comporte bien 9 caractères
            if (noCarte.Length < 9)
            {
                MessageBox.Show("Le numéro de la carte doit contenir 9 caractères numériques.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskCarte.BackColor = Color.LightPink;
                return;
            }
            // Valide que le nip comporte bien 5 caractères
            if (nip.Length < 5)
            {
                MessageBox.Show("Votre NIP doit contenir 5 caractères numériques.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskNip.BackColor = Color.LightPink;
                return;
            }

            Boolean admin;
            // Valide si la texte box admin a été coché
            if (ckAdmin.CheckState == CheckState.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            if (BD.DataClients.GetInstance().ValiderClientExiste(noCarte))
            {
                MessageBox.Show("Ce numéro de carte est déjà existant.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskCarte.BackColor = Color.LightPink;
                return;
            }

            // Ajoute à la base de données
            if (BD.DataClients.GetInstance().AjouterClient(noCarte, tbNom.Text, tbPrenom.Text, admin,
                            Convert.ToInt16(cbForfait.SelectedItem.ToString().Substring(0, 1)), nip))
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton annuler, la fenêtre se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Charge la ComboBox qui contient la liste de forfait
        /// </summary>
        private void ChargerCBForfait()
        {
            List<String> listForfaits = BD.DataClients.GetInstance().GetListForfaits();

            if (listForfaits != null)
            {
                foreach (String s in listForfaits)
                {
                    cbForfait.Items.Add(s);
                }
            }
        }
    }
}
