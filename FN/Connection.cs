// *********************************************************************
// Programmeur : Francis Blanchette
// Date : 12 mars 2021
// Fichier : Connection.cs
//
// Fenêtre de connection 
// *********************************************************************

using System;
using System.Data;
using System.Windows.Forms;

namespace GuichetAutomatique.FN
{
    public partial class Connection : Form
    {
        GuichetAutomatique guichetAutomatique;

        /// <summary>
        /// Nombre d'essaie pour le nip
        /// </summary>
        int essaie;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Connection()
        {
            InitializeComponent();
            essaie = 0;
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="_GuichetAutomatique">Classe GuichetAutomatique</param>
        public Connection(GuichetAutomatique _GuichetAutomatique)
        {
            InitializeComponent();
            guichetAutomatique = _GuichetAutomatique;
            essaie = 0;
        }

        /// <summary>
        /// Lorsque l'utilisateur clic sur le X, l'application se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Lorsque l'utilisateur clic sur le bouton entrer, on fait les validations et on ouvre l'application
        /// Ou la ferme selon si l'utilisateur a entré 3 fois le mauvais mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEntrer_Click(object sender, EventArgs e)
        {
            DataTable client;
            String noCarte = mskCarte.Text.Replace(" ", "");
            String nip = mskNip.Text.Replace(" ", "");

            // Valide si le numéro de carte existe
            if (!BD.DataClients.GetInstance().ValiderClientExiste(noCarte))
            {
                MessageBox.Show("Numéro de carte inexistant.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valide si le numéro de carte existe
            if (BD.DataClients.GetInstance().ValiderClientActif(noCarte))
            {
                MessageBox.Show("Votre carte a été désactivée, veuillez voir un conseiller.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valide si le nip est bon
            if (BD.DataClients.GetInstance().ValiderNipClient(noCarte, nip))
            {
                client = BD.DataClients.GetInstance().GetClient(noCarte);
                GuichetAutomatique.NoCarte = client.Rows[0][0].ToString();
                GuichetAutomatique.NomClient = client.Rows[0][2].ToString() + ' ' + client.Rows[0][1].ToString();
                GuichetAutomatique.SoldeCompte = Convert.ToDouble(client.Rows[0][3].ToString());
                GuichetAutomatique.ForfaitCompte = Convert.ToInt16(client.Rows[0][5].ToString());

                guichetAutomatique.Connection(Convert.ToBoolean(client.Rows[0][4].ToString()));

                // Affiche la fenêtre principale
                guichetAutomatique.Show();

                // Si ou la fenêtre de connection se ferme et la fenêtre principale s'ouvre
                this.Close();
            }
            else
            {
                // Incrémente le nombre d'essai
                essaie++;

                // L'utilisateur a 3 essai
                if (essaie < 3)
                {
                    MessageBox.Show("Nip invalide. Veuillez réessayer", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Votre compte a été désactivé. Veuillez voir un conseiller.", "Guichet Automatique - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Désactive le client
                    BD.DataClients.GetInstance().DesactiverClient(noCarte);

                    // Ferme l'application
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur clic sur le bouton quitter, l'application se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mskNip_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
