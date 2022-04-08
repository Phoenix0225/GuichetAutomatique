using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GuichetAutomatique.BD
{
    class DataOperations
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataOperations instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataOperations()
        {
            this.con = new MySqlConnection("Server=localhost;Database=guichet_automatique;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Systeme</returns>
        public static DataOperations GetInstance()
        {
            if (instance == null)
            {
                instance = new DataOperations();
            }
            return instance;
        }

        /// <summary>
        /// Garde un historique de la transaction effectué.
        /// </summary>
        /// <param name="date">Date de la transaction</param>
        /// <param name="client_id">ID du client</param>
        /// <param name="type_id">Type de la transaction
        ///                             1 = Dépôt d'argent
        ///                             2 = Dépôt d'un chèque
        ///                             3 = Retrait d'argent
        ///                             4 = Achat
        ///                             5 = Frais d'utilisation
        /// </param>
        /// <param name="nom_commerce">Nom du commerce lors de l'achat</param>
        /// <param name="montant">Montant de la transaction</param>
        /// <param name="frais">Les frais de la transaction</param>
        /// <returns>True si succès, false si échec</returns>
        private Boolean LogMontant(DateTime date, int client_id, int type_id, string nom_commerce, double montant, double frais)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                if (!nom_commerce.Equals("null"))
                {
                    commande.CommandText = "INSERT INTO transactions VALUES (null, @date, @client_id, @type_id, @nom_commerce, @montant, @frais);";
                    commande.Parameters.Add("@nom_commerce", MySqlDbType.String).Value = nom_commerce;
                }
                else
                {
                    commande.CommandText = "INSERT INTO transactions VALUES (null, @date, @client_id, @type_id, null, @montant, @frais);";
                }

                commande.Parameters.Add("@date", MySqlDbType.DateTime).Value = date;
                commande.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client_id;
                commande.Parameters.Add("@type_id", MySqlDbType.Int32).Value = type_id;
                commande.Parameters.Add("@montant", MySqlDbType.Double).Value = montant;
                commande.Parameters.Add("@frais", MySqlDbType.Double).Value = frais;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return false;
            }
        }

        /// <summary>
        /// Ajout du montant au compte associé à la carte lors du dépot.
        /// </summary>
        /// <param name="id_carte">Numéro de la carte</param>
        /// <param name="montant">Montant du dépot</param>
        /// /// <param name="type_depot">Type de dépot: 0 = comptant, 1 = chèque</param>
        /// <returns>True si succès, false si échec</returns>
        public bool Depot(int id_carte, double montant, int type_depot)
        {
            double frais = CalculerFrais(montant, false);
            int type_transaction;

            if (type_depot == 0)
                type_transaction = 1;
            else
                type_transaction = 2;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "UPDATE clients " +
                                        "SET solde_compte = solde_compte + @montant " +
                                        "WHERE id_carte = @id_carte;";

                commande.Parameters.Add("@montant", MySqlDbType.Double).Value = montant;
                commande.Parameters.Add("@id_carte", MySqlDbType.Int32).Value = id_carte;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                chargerFrais(id_carte, montant, false);

                if (LogMontant(DateTime.Today, id_carte, type_transaction, "null", montant, frais))
                    return true;
                else
                    return false;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return false;
            }
        }

        /// <summary>
        /// Soustraction du montant de l'achat au compte associé à la carte lors de l'achat.
        /// </summary>
        /// <param name="id_carte">Numéro de la carte</param>
        /// <param name="montant">Montant du dépot</param>
        /// /// <param name="type_achat">Type achat</param>
        /// <returns>True si succès, false si échec</returns>
        public bool Achat(int id_carte, double montant, string commerce, int type_achat)
        {
            double frais = CalculerFrais(montant, true);

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "UPDATE clients " +
                                        "SET solde_compte = solde_compte - @montant " +
                                        "WHERE id_carte = @id_carte;";

                commande.Parameters.Add("@montant", MySqlDbType.Double).Value = montant;
                commande.Parameters.Add("@id_carte", MySqlDbType.Int32).Value = id_carte;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                chargerFrais(id_carte, montant, true);

                if (LogMontant(DateTime.Today, id_carte, 4, commerce, montant, frais))
                    return true;
                else
                    return false;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return false;
            }
        }

        /// <summary>
        /// Charger les frais lors d'une transaction.
        /// </summary>
        /// <param name="id_carte">Numéro de la carte</param>
        /// <param name="montant">Montant de la transaction</param>
        /// <param name="achatRetrait">Valeur vrai pour un achat ou retrait</param>
        /// <returns>True si succès, false si échec</returns>
        public void chargerFrais(int id_carte, double montant, bool achatRetrait)
        {
            double frais = CalculerFrais(montant, achatRetrait);

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "UPDATE clients " +
                                        "SET solde_compte = solde_compte - @frais " +
                                        "WHERE id_carte = @id_carte;";

                commande.Parameters.Add("@id_carte", MySqlDbType.Int32).Value = id_carte;
                commande.Parameters.Add("@frais", MySqlDbType.Double).Value = frais;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Calcule les frais à charger au client
        /// </summary>
        /// <param name="montant">Montant de la transaction</param>
        /// <param name="achatRetrait">Valeur vrai pour un achat ou retrait</param>
        /// <returns>Les frais</returns>
        public double CalculerFrais(double montant, bool achatRetrait)
        {
            DataTable tabClient = null;
            MySqlDataReader r = null;

            int id_forfait = Convert.ToInt32(GuichetAutomatique.ForfaitCompte);
            double solde = Convert.ToDouble(GuichetAutomatique.SoldeCompte);

            double frais = 0;
            double soldeMinimum = 0;

            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                        "FROM forfaits " +
                                        "WHERE id_forfait = @id_forfait;";

                commande.Parameters.Add("@id_forfait", MySqlDbType.String).Value = id_forfait;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("client");
                tabClient.Load(r);

                r.Close();
                con.Close();
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (r != null)
                    r.Close();
            }

            soldeMinimum = Convert.ToDouble(tabClient.Rows[0][2].ToString());
            frais = Convert.ToDouble(tabClient.Rows[0][3].ToString());

            double nouveauSolde = 0;

            if (achatRetrait)
            {
                nouveauSolde = solde - (frais + montant);
            }
            else
            {
                nouveauSolde = solde + (frais + montant);
            }

            if (nouveauSolde < soldeMinimum)
                frais = 1;

            return frais;
        }

        /// <summary>
        /// Effectue un retrait
        /// </summary>
        /// <param name="id_carte">ID de la carte</param>
        /// <param name="montant">Montant du retrait</param>
        /// <returns>true si succès, false si erreur</returns>
        public bool Retrait(int id_carte, double montant)
        {
            double frais = CalculerFrais(montant, true);

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "UPDATE clients " +
                                        "SET solde_compte = solde_compte - @montant " +
                                        "WHERE id_carte = @id_carte;";

                commande.Parameters.Add("@montant", MySqlDbType.Double).Value = montant;
                commande.Parameters.Add("@id_carte", MySqlDbType.Int32).Value = id_carte;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                chargerFrais(id_carte, montant, true);

                if (LogMontant(DateTime.Today, id_carte, 3, "null", montant, frais))
                    return true;
                else
                    return false;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                return false;
            }
        }

        /// <summary>
        /// Vérification du montant pour le retrait
        /// </summary>
        /// <param name="id_carte">ID de la carte</param>
        /// <param name="montant">Montant du retrait</param>
        /// <returns>
        ///     -1 = Montant pour aujourd'hui atteint
        ///     0 = Succès
        ///     -10 = Erreur
        ///     Autre double = Impossible de retirer, le chiffre est le nombre qu'il peut retirer encore aujourd'hui
        /// </returns>
        public double VerifRetraitParJour(int id_carte, double montant)
        {
            DataTable tabClient = null;
            MySqlDataReader r = null;

            double montantAjd;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT montant_total " +
                                        "FROM vw_retrait_jour " +
                                        "WHERE client_id = @id_carte AND date_transaction = @date_transaction";

                commande.Parameters.Add("@date_transaction", MySqlDbType.Date).Value = DateTime.Today;
                commande.Parameters.Add("@id_carte", MySqlDbType.Int32).Value = id_carte;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("montant");
                tabClient.Load(r);

                r.Close();
                con.Close();

                if (tabClient.Rows.Count > 0)
                    montantAjd = Convert.ToDouble(tabClient.Rows[0]["montant_total"]);
                else
                    montantAjd = 0;

                if (montantAjd >= 1000)
                {
                    return -1;
                }
                else if (montant + montantAjd > 1000)
                {
                    return 1000 - montantAjd;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                if (r != null)
                    r.Close();

                return -10;
            }
        }
    }
}
