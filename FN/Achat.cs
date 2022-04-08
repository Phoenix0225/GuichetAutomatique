// *********************************************************************
// Programmeur : Jérémy LOrs
// Date : 8 mars 2021
// Fichier : Achat.cs
//
// Classe pour les achats
// *********************************************************************

using System;
using System.Windows.Forms;

namespace GuichetAutomatique.FN
{
    public partial class Achat : UserControl
    {
        GuichetAutomatique fnGuichet;

        double montantAchat = 0;
        string commerce = "";

        public Achat()
        {
            InitializeComponent();

            //Enlève les flèches de la zone de texte du montant du chèque.
            erreur.Visible = false;
            mtAchat.Controls[0].Visible = false;
        }

        public Achat(GuichetAutomatique _Guichet)
        {
            InitializeComponent();

            //Enlève les flèches de la zone de texte du montant du chèque.
            erreur.Visible = false;
            mtAchat.Controls[0].Visible = false;

            fnGuichet = _Guichet;
        }

        /// <summary>
        /// Méthode de fermeture du contrôle utilisateur.
        /// </summary>
        private void FermerUC()
        {
            this.Parent.Controls.Remove(this);
        }

        /// <summary>
        /// Vérification des champs et ajout à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAchat_Click(object sender, EventArgs e)
        {
            montantAchat = Convert.ToDouble(mtAchat.Value);

            // limite a 2 decimal apres la virgule
            montantAchat = Math.Round(montantAchat, 2);
            txtCommerce.Text = txtCommerce.Text.Replace(" ", "");
            commerce = txtCommerce.Text;
            int noCarte = Convert.ToInt32(GuichetAutomatique.NoCarte);
            double solde = GuichetAutomatique.SoldeCompte;
            double frais = BD.DataOperations.GetInstance().CalculerFrais(montantAchat, true);

            // Vérifie que le montant est supérieur à 0
            if (montantAchat == 0.00)
            {
                erreur.Text = "Le montant doit être supérieur à 0";
                erreur.Visible = true;
            }

            // Vérifie que le champ commerce est rempli
            else if (commerce == "")
            {
                erreur.Text = "Vous devez entrer un commerce pour l'achat";
                erreur.Visible = true;
            }

            // Vérifie que le montant est disponible pour l'achat
            else if ((montantAchat + frais) > solde)
            {
                erreur.Text = "Fond insuffisant";
                erreur.Visible = true;
                mtAchat.Value = 0;
                txtCommerce.Text = "";
            }

            else
            {
                // Passe l'achat
                if (BD.DataOperations.GetInstance().Achat(noCarte, montantAchat, commerce, 4))
                {
                    fnGuichet.UpdateSolde();
                    FermerUC();

                    fnGuichet.AfficherTransactions();
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite. Veuillez contacter le support informatique au 1-800-450-1234",
                                        "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Autorise seulement les caractères Lettre et Nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCommerce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                erreur.Visible = false;
            }
        }

        /// <summary>
        /// Événement du boutton pour fermer le contrôle utilisateur DepotCheque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click_1(object sender, EventArgs e)
        {
            FermerUC();
        }

        /// <summary>
        /// Empêcher le premier caractère d'être un espace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCommerce_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                erreur.Text = "Le premier caractère ne peut pas être une espace";
                erreur.Visible = true;
                txtCommerce.Text = "";
            }
        }

        /// <summary>
        /// Reset les champs à zéro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            mtAchat.Value = 0;
            txtCommerce.Text = "";
            erreur.Visible = false;
        }

        /// <summary>
        /// Lorsque le numericUpDown est vide remet un zero automatique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtAchat_Validated(object sender, EventArgs e)
        {
            if (mtAchat.Text == "")
            {
                mtAchat.Text = "0";
            }
        }
    }
}
