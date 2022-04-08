// *********************************************************************
// Programmeur : Cédric Noël
// Date : 12 mars 2021
// Fichier : GuichetAutomatique.cs
//
// Fenêtre principale du guichet automatique.
// *********************************************************************

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GuichetAutomatique
{
    public partial class GuichetAutomatique : Form
    {
        //*****************Variables pour le déplacement de la fenêtre.*****************
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //*****************Variables pour le déplacement de la fenêtre.*****************

        FN.Clients fClients;
        FN.DepotRetrait ucDepotRetrait;
        FN.Connection fnConnection;
        FN.Achat ucAchat;

        private static String noCarte;
        private static String nomClient;
        private static Double soldeCompte;
        private static Int16 forfaitCompte;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public GuichetAutomatique()
        {
            InitializeComponent();
            lDateJour.Text = DateTime.Today.ToString("d MMMM yyyy");
        }

        //********************************Méthode Get et Set**************************//
        public static string NoCarte { get => noCarte; set => noCarte = value; }
        public static string NomClient { get => nomClient; set => nomClient = value; }
        public static double SoldeCompte { get => soldeCompte; set => soldeCompte = value; }
        public static short ForfaitCompte { get => forfaitCompte; set => forfaitCompte = value; }
        //********************************Méthode Get et Set**************************//

        /// <summary>
        /// Méthode du boutton pour fermer l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Méthode pour déplacer la fenêtre à partir du haut de la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Ouverture de la fenêtre d'ajout de client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LAjoutClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fClients = new FN.Clients();
            fClients.ShowDialog();
        }

        /// <summary>
        /// Ouverture de la fenêtre de dépot de chèque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lDepotCheque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucDepotRetrait = new FN.DepotRetrait(this, "depotCheque");
            OuvrirFenetreDepotRetrait();
        }

        /// <summary>
        /// Ouverture de la fenêtre de dépot d'argent comptant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lDepotArgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucDepotRetrait = new FN.DepotRetrait(this, "depotComptant");
            OuvrirFenetreDepotRetrait();
        }

        /// <summary>
        /// Ouverture de la fenêtre de retrait.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lRetrait_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucDepotRetrait = new FN.DepotRetrait(this, "retrait");
            OuvrirFenetreDepotRetrait();
        }

        /// <summary>
        /// Ouverture du du User Control DepotRetrait.
        /// </summary>
        private void OuvrirFenetreDepotRetrait()
        {
            pMain.Controls.Add(ucDepotRetrait);
            ucDepotRetrait.Dock = DockStyle.Fill;
            ucDepotRetrait.BringToFront();
        }

        /// <summary>
        /// Ouverture de la fenêtre Achat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lAchat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucAchat = new FN.Achat(this);

            pMain.Controls.Add(ucAchat);
            ucAchat.Dock = DockStyle.Fill;
            ucAchat.BringToFront();
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton déconnection, on baisse la fenêtre
        /// et on affiche la fenêtre de connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lDeconnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lBonjourNom.Text = "Bonjour";
            lbSolde.Text = "";

            // Cache la fenêtre principale
            this.Hide();

            // Ouvre une nouvelle fenêtre de connection
            fnConnection = new FN.Connection(this);
            fnConnection.ShowDialog();
        }

        /// <summary>
        /// Au moment de charger l'application, on fait afficher la fenêtre de connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuichetAutomatique_Load(object sender, EventArgs e)
        {
            fnConnection = new FN.Connection(this);
            fnConnection.ShowDialog();
        }

        /// <summary>
        /// Ajoute les informations de l'utilisateur a la fenêtre principal
        /// </summary>
        /// <param name="_IsAdmin">Si l'utilisateur est admin</param>
        public void Connection(Boolean _IsAdmin)
        {
            // Si admin
            if (_IsAdmin)
            {
                // Link AjouterClient visible
                lAjoutClient.Visible = true;
            }
            // Si non admin
            else
            {
                // Link AjouterClient non visible
                lAjoutClient.Visible = false;
            }

            // Affiche le nom du client
            lBonjourNom.Text = "Bonjour " + nomClient;
            // Affiche le solde du compte
            UpdateSolde();

            AfficherTransactions();
        }

        /// <summary>
        /// Met a jour le solde du compte
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="option">0 = Depot, 1 = Retrait</param>
        public void UpdateSolde()
        {
            soldeCompte = Convert.ToDouble(BD.DataClients.GetInstance().GetClient(NoCarte).Rows[0][3].ToString());

            lbSolde.Text = soldeCompte.ToString("0.00") + " $";

            if(soldeCompte <= Convert.ToInt32(BD.DataClients.GetInstance().GetForfait(forfaitCompte).Rows[0][2]))
            {
                lbSolde.ForeColor = Color.Red;
            }
            else lbSolde.ForeColor = Color.White;
        }

        /// <summary>
        /// Méthode pour l'affichage des transactions
        /// </summary>
        public void AfficherTransactions()
        {
            // Va chercher les 3 dernières transactions
            DataTable transaction = BD.DataClients.GetInstance().GetTransactions(NoCarte);

            // Vide le contenu du panel principal
            pnTransactions.Controls.Clear();

            // Si le DataTable transaction contient des enregistrements
            if (transaction.Rows.Count > 0)
            {
                Panel panel;
                Label lbDateTransaction, lbDescription, lbMontant, lbFrais;

                for (int i = transaction.Rows.Count; i > 0; i--)
                {
                    panel = new Panel();                               // Création d'un nouveau panel

                    lbDateTransaction = new Label();                   // Création d'un nouveau Label
                    lbDescription = new Label();                       // Création d'un nouveau Label
                    lbMontant = new Label();                           // Création d'un nouveau Label
                    lbFrais = new Label();                             // Création d'un nouveau Label

                    panel.Parent = pnTransactions; panel.Name = "Transaction" + i; // Ajout le panel
                    panel.Dock = DockStyle.Top;
                    panel.Size = new System.Drawing.Size(918, 76);  // Ajuste la grandeur

                    // Ajoute les label
                    lbDateTransaction.Parent = panel;
                    lbDescription.Parent = panel;
                    lbMontant.Parent = panel;
                    lbFrais.Parent = panel;

                    // Positionne les labels
                    lbDateTransaction.Location = new System.Drawing.Point(33, 26);
                    lbDescription.Location = new System.Drawing.Point(230, 26);
                    lbMontant.Location = new System.Drawing.Point(619, 26);
                    lbFrais.Location = new System.Drawing.Point(800, 26);

                    // Inscrit le texte des label
                    // ROWS[i-1] car la boucle tourne à l'envert et on dpoit arriver a 0
                    lbDateTransaction.Text = Convert.ToDateTime(transaction.Rows[i-1][2].ToString()).ToString("d MMMM yyyy");
                    lbDescription.Text = transaction.Rows[i-1][3].ToString();
                    lbMontant.Text = Convert.ToDouble(transaction.Rows[i-1][4].ToString()).ToString("0.00") + " $";
                    if (!transaction.Rows[i - 1][5].ToString().Equals(""))
                    {
                        lbFrais.Text = Convert.ToDouble(transaction.Rows[i - 1][5].ToString()).ToString("0.00") + " $";
                    }
                    else lbFrais.Text = "0,00 $";

                    // Ajuste la couleur des label
                    lbDateTransaction.ForeColor = Color.White;
                    lbDescription.ForeColor = Color.White;
                    lbMontant.ForeColor = Color.White;
                    lbFrais.ForeColor = Color.White;

                    // Ajuste la grandeur du label car si la date ou le montant était trop grand
                    // il n'était pas totalement visible
                    lbDateTransaction.Size = new System.Drawing.Size(180, 25);
                    lbDescription.Size = new System.Drawing.Size(349, 25);
                    lbMontant.Size = new System.Drawing.Size(180, 25);
                }
            }
        }
    }
}
