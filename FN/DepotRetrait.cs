// *********************************************************************
// Programmeur : Cédric Noel
// Date : 12 mars 2021
// Fichier : DepotRetrait.cs
//
// Classe pour les dépots et les retraits
// *********************************************************************

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GuichetAutomatique.FN
{
    public partial class DepotRetrait : UserControl
    {
        double montantDepot = 0;
        List<string> listMontantDepot = new List<string>();

        /// <summary>
        /// Différentes options : "retrait", "depotCheque", "depotComptant"
        /// </summary>
        string option;

        GuichetAutomatique guichetAutomatique;

        public DepotRetrait(GuichetAutomatique guichet, string _option)
        {
            InitializeComponent();

            option = _option;
            guichetAutomatique = guichet;

            if (option.Equals("depotCheque") || option.Equals("depotComptant"))
                lInfos.Text = "Entrez le montant du dépot.";
            else
                lInfos.Text = "Entrez le montant du retrait.";

            //Enlève les flèches de la zone de texte du montant du chèque.
            nbrMontantCheque.Controls[0].Visible = false;
        }

        /// <summary>
        /// Événement du boutton pour fermer le contrôle utilisateur DepotCheque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            FermerUC();
        }

        /// <summary>
        /// Méthode de fermeture du contrôle utilisateur.
        /// </summary>
        private void FermerUC()
        {
            this.Parent.Controls.Remove(this);
        }

        /// <summary>
        /// Changement du montant dans la zone de texte.
        /// </summary>
        private void AjoutNombreText()
        {
            string strMontantDepot = "";
            bool unNombre = false;
            //Position de la virgule dans le montant.
            int posVirgule = 0;

            if (listMontantDepot.Count == 1)
            {
                listMontantDepot.Insert(0, "0");
                unNombre = true;
            }

            if (listMontantDepot.Count >= 3)
            {
                posVirgule = listMontantDepot.Count - 2;
            }

            listMontantDepot.Insert(posVirgule, Convert.ToString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));

            foreach (string s in listMontantDepot)
            {
                strMontantDepot += s;
            }

            montantDepot = Convert.ToDouble(strMontantDepot);

            if (montantDepot <= 1000000000)
                nbrMontantCheque.Value = (decimal)montantDepot;

            //Retire la virgule de la liste après l'affichage.
            listMontantDepot.RemoveAt(posVirgule);

            //Retire le 0 ajouter pour un nombre de type .0*
            if (unNombre)
                listMontantDepot.RemoveAt(0);
        }

        /// <summary>
        /// Ajoute le nombre indiqué à la liste et dans la zone de texte.
        /// </summary>
        /// <param name="nbr">Nombre à ajouter</param>
        private void AjouterNombre(string nbr)
        {
            listMontantDepot.Add(nbr);
            AjoutNombreText();
        }

        #region Boutton Nombres

        /// <summary>
        /// Ajout d'un "1" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt1_Click(object sender, EventArgs e)
        {
            AjouterNombre("1");
        }

        /// <summary>
        /// Ajout d'un "2" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt2_Click(object sender, EventArgs e)
        {
            AjouterNombre("2");
        }

        /// <summary>
        /// Ajout d'un "3" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt3_Click(object sender, EventArgs e)
        {
            AjouterNombre("3");
        }

        /// <summary>
        /// Ajout d'un "4" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt4_Click(object sender, EventArgs e)
        {
            AjouterNombre("4");
        }

        /// <summary>
        /// Ajout d'un "5" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt5_Click(object sender, EventArgs e)
        {
            AjouterNombre("5");
        }

        /// <summary>
        /// Ajout d'un "6" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt6_Click(object sender, EventArgs e)
        {
            AjouterNombre("6");
        }

        /// <summary>
        /// Ajout d'un "7" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt7_Click(object sender, EventArgs e)
        {
            AjouterNombre("7");
        }

        /// <summary>
        /// Ajout d'un "8" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt8_Click(object sender, EventArgs e)
        {
            AjouterNombre("8");
        }

        /// <summary>
        /// Ajout d'un "9" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt9_Click(object sender, EventArgs e)
        {
            AjouterNombre("9");
        }

        /// <summary>
        /// Ajout d'un "0" à la liste du montant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt0_Click(object sender, EventArgs e)
        {
            AjouterNombre("0");
        }

        #endregion

        /// <summary>
        /// Clear la zone du montant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            ClearMontant();
        }

        /// <summary>
        /// Clear le NumericUpDown
        /// </summary>
        private void ClearMontant()
        {
            nbrMontantCheque.Value = 0;
            montantDepot = 0;
            listMontantDepot.Clear();
        }

        /// <summary>
        /// Méthode pour confirmer la transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConfirmer_Click(object sender, EventArgs e)
        {
            if (option.Equals("depotCheque"))
                DeposerCheque();
            else if (option.Equals("depotComptant"))
                DeposerComptant();
            else if (option.Equals("retrait"))
                Retrait();
        }
        
        /// <summary>
        /// Effectue la transaction de retirer un montant
        /// </summary>
        private void Retrait()
        {
            double valeurDepot = Convert.ToDouble(nbrMontantCheque.Value);
            double montant;
            int noCarte = Convert.ToInt32(GuichetAutomatique.NoCarte);
            double frais = BD.DataOperations.GetInstance().CalculerFrais(valeurDepot, true);
            double solde = GuichetAutomatique.SoldeCompte;

            if (valeurDepot > 0)
            {
                if (valeurDepot % 20 == 0)
                {
                    if(valeurDepot + frais <= solde)
                    {
                        montant = valeurDepot;
                    }
                    else
                    {
                        MessageBox.Show("Vous n'avez pas assez d'argent dans votre compte pour retirer ce montant.", 
                                        "Guichet Automatique - ERREUR",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearMontant();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Le montant doit être un multiple de 20.", "Guichet Automatique - ATTENTION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMontant();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer le montant du dépot.",
                                 "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double montantVerif = BD.DataOperations.GetInstance().VerifRetraitParJour(noCarte, montant);

            if (montantVerif == 0)
            {
                if (BD.DataOperations.GetInstance().Retrait(noCarte, montant))
                {
                    guichetAutomatique.AfficherTransactions();
                    guichetAutomatique.UpdateSolde();
                    FermerUC();
                }
                else
                {
                    MessageErreur();
                    return;
                }
            }
            else if (montantVerif == -1)
            {
                MessageBox.Show("Vous avez déjà atteint le maximum de 1000$ de retrait ajourd'hui.\n\nVeuillez revenir demain.",
                                        "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (montantVerif == -10)
            {
                MessageErreur();
                return;
            }
            else
            {
                MessageBox.Show($"Vous avez {montantVerif}$ restant à la limite de 1000$ pour aujourd'hui.",
                                        "Guichet Automatique - INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMontant();
                return;
            }
        }

        /// <summary>
        /// Effectue la transaction de déposer de l'argent comptant
        /// </summary>
        private void DeposerComptant()
        {
            double montant;
            int noCarte = Convert.ToInt32(GuichetAutomatique.NoCarte);

            if (nbrMontantCheque.Value > 0) {
                if (nbrMontantCheque.Value % 5 == 0)
                {
                    montant = Convert.ToDouble(nbrMontantCheque.Value);
                }
                else
                {
                    MessageBox.Show("Le montant doit être un multiple de 5.",
                                        "Guichet Automatique - ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMontant();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer le montant du dépot.",
                                        "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BD.DataOperations.GetInstance().Depot(noCarte, montant, 0))
            {
                guichetAutomatique.AfficherTransactions();
                guichetAutomatique.UpdateSolde();
                FermerUC();
            }
            else
            {
                MessageErreur();
            }
        }

        /// <summary>
        /// Envoie un message d'erreur
        /// </summary>
        private static void MessageErreur()
        {
            MessageBox.Show("Une erreur s'est produite. Veuillez contacter le support informatique au 1-800-450-1234",
                                        "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Effectue la transaction de déposer un chèque
        /// </summary>
        private void DeposerCheque()
        {
            double montant;
            int noCarte = Convert.ToInt32(GuichetAutomatique.NoCarte);

            if (nbrMontantCheque.Value > 0)
                montant = Convert.ToDouble(nbrMontantCheque.Value);
            else
            {
                MessageBox.Show("Veuillez entrer le montant du chèque.",
                                        "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BD.DataOperations.GetInstance().Depot(noCarte, montant, 1))
            {
                guichetAutomatique.AfficherTransactions();
                guichetAutomatique.UpdateSolde();
                FermerUC();
            }
            else
            {
                MessageErreur();
            }
        }
    }
}
