// *********************************************************************
// Programmeur : Francis Blanchette
// Date : 12 mars 2021
// Fichier : DataClients.cs
//
// Classe static pour la connection a la base de données
// *********************************************************************

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GuichetAutomatique.BD
{
    class DataClients
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataClients instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataClients()
        {
            this.con = new MySqlConnection("Server=localhost;Database=guichet_automatique;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Systeme</returns>
        public static DataClients GetInstance()
        {
            if (instance == null)
            {
                instance = new DataClients();
            }
            return instance;
        }

        /********************************* Méthode pour les forfaits **************************************/

        /// <summary>
        /// Retourne la liste des forfaits sous forme ID - DESCRIPTION
        /// </summary>
        /// <returns>List String</returns>
        public List<String> GetListForfaits()
        {
            MySqlDataReader r = null;

            List<String> listForfaits = new List<String>();

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM forfaits; ";

                con.Open();
                r = commande.ExecuteReader();

                while (r.Read())
                {
                    listForfaits.Add(r[0].ToString() + " - " + r[1].ToString());
                }

                r.Close();
                con.Close();

                return listForfaits;
            }
            catch
            {
                if (r != null)
                    r.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();

                return listForfaits;
            }
        }

        /********************************* Méthode pour les clients **************************************/

        /// <summary>
        /// Méthode qui permet l'ajout de nouveaux clients dans la base de données
        /// </summary>
        /// <param name="_IdCarte">Numéro de la carte</param>
        /// <param name="_Nom">Nom du client</param>
        /// <param name="_Prenom">Prénom du client</param>
        /// <param name="_Admin">Accès admin (Boolean)</param>
        /// <param name="_Forfait">Forfait du client</param>
        /// <param name="_Nip">Nip du client</param>
        /// <returns>DataTable</returns>
        public Boolean AjouterClient(String _IdCarte, String _Nom, String _Prenom, Boolean _Admin, int _Forfait, String _Nip)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "INSERT INTO clients " +
                                       "VALUES(@idCarte, @nom, @prenom, DEFAULT, @admin, @forfait, @nip, DEFAULT); ";

                commande.Parameters.Add("@idCarte", MySqlDbType.String).Value = _IdCarte;
                commande.Parameters.Add("@nom", MySqlDbType.String).Value = _Nom;
                commande.Parameters.Add("@prenom", MySqlDbType.String).Value = _Prenom;
                commande.Parameters.Add("@admin", MySqlDbType.Int16).Value = _Admin;
                commande.Parameters.Add("@forfait", MySqlDbType.Int16).Value = _Forfait;
                commande.Parameters.Add("@nip", MySqlDbType.String).Value = _Nip;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception e)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show(e.Message, "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        /// <summary>
        /// Retourne les informations d'un client
        /// </summary>
        /// <param name="_NoCarte">Numéro de carte du client</param>
        /// <returns>DataTable</returns>
        public DataTable GetClient(String _NoCarte)
        {
            DataTable tabClient = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM clients " +
                                       "WHERE id_carte = @idCarte  ";

                commande.Parameters.Add("@idCarte", MySqlDbType.String).Value = _NoCarte;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("client");
                tabClient.Load(r);

                r.Close();
                con.Close();

                return tabClient;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (r != null)
                    r.Close();

                return tabClient;
            }
        }

        /********************************* Méthode pour les cartes **************************************/

        /// <summary>
        /// Méthode qui valide si le client existe
        /// </summary>
        /// <param name="_NoCarte">Numéro de la carte du client</param>
        /// <returns>Boolean</returns>
        public Boolean ValiderClientExiste(String _NoCarte)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = $"SELECT count(*) FROM clients " +
                                       $"WHERE id_carte=@noCarte;";
                commande.Parameters.AddWithValue("@noCarte", _NoCarte);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
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
        /// Valide si la carte du client est active
        /// </summary>
        /// <param name="_NoCarte"></param>
        /// <returns></returns>
        public Boolean ValiderClientActif(String _NoCarte)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = $"SELECT count(*) FROM clients " +
                                       $"WHERE id_carte=@noCarte AND statut_id = 2;";
                commande.Parameters.AddWithValue("@noCarte", _NoCarte);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
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
        /// Méthode qui valide le NIP du client
        /// </summary>
        /// <param name="_NoCarte">Numéro de la carte du client</param>
        /// <param name="_Nip">Nip du client</param>
        /// <returns>Boolean</returns>
        public Boolean ValiderNipClient(String _NoCarte, String _Nip)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = $"SELECT count(*) " +
                                       $"FROM clients " +
                                       $"WHERE id_carte=@noCarte AND nip = @nip;";

                commande.Parameters.AddWithValue("@noCarte", _NoCarte);
                commande.Parameters.AddWithValue("@nip", _Nip);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
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
        /// Méthode qui désactive la carte d'un client
        /// </summary>
        /// <param name="_NoCarte">Numéro de la carte</param>
        public void DesactiverClient(String _NoCarte)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "UPDATE clients " +
                                       "SET statut_id = 2 " +
                                       "WHERE id_carte = @idcarte;";

                commande.Parameters.Add("@idcarte", MySqlDbType.String).Value = _NoCarte;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Guichet Automatique - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /********************************* Méthode pour les transactions**************************************/

        /// <summary>
        /// Retourne les 3 dernieres transactions qu'un client à fait
        /// </summary>
        /// <param name="_NoCarte">Numéro de carte du client</param>
        /// <returns>DataTable</returns>
        public DataTable GetTransactions(String _NoCarte)
        {
            DataTable tabTransactions = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM vw_transactions " +
                                       "WHERE client_id = @idCarte  " +
                                       "LIMIT 3; "; // Limite a 3 transactions

                commande.Parameters.Add("@idCarte", MySqlDbType.String).Value = _NoCarte;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabTransactions = new DataTable("Transaction");
                tabTransactions.Load(r);

                r.Close();
                con.Close();

                return tabTransactions;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (r != null)
                    r.Close();

                return tabTransactions;
            }
        }

        /// <summary>
        /// Méthode qui retourne un forfait
        /// </summary>
        /// <param name="_NoForfait">ID du forfait</param>
        /// <returns>DataTable</returns>
        public DataTable GetForfait(short _NoForfait)
        {
            DataTable tabTransactions = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM forfaits " +
                                       "WHERE id_forfait = @idForfait;  ";

                commande.Parameters.Add("@idForfait", MySqlDbType.Int32).Value = _NoForfait;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabTransactions = new DataTable("Forfait");
                tabTransactions.Load(r);

                r.Close();
                con.Close();

                return tabTransactions;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (r != null)
                    r.Close();

                return tabTransactions;
            }
        }
    }
}
