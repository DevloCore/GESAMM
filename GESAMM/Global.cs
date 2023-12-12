using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace GESAMM
{
    public static class Global
    {
        public static string username;
        public static SqlConnection db { get; private set; }

        public static Dictionary<string, Famille> familles;
        public static Dictionary<string, Medicament> medicaments;
        public static Dictionary<int, Etape> etapes;
        public static Dictionary<int, Decision> decisions;

        public static async Task<bool> Init()
        {
            familles = new Dictionary<string, Famille>();
            medicaments = new Dictionary<string, Medicament>();
            etapes = new Dictionary<int, Etape>();
            decisions = new Dictionary <int, Decision>();

            SqlConnectionStringBuilder builder = new()
            {
                DataSource = ".\\SQLEXPRESS",
                //builder.UserID = "<your_username>";
                //builder.Password = "<your_password>";
                InitialCatalog = "GESAMM",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
                MultipleActiveResultSets = true
            };

            db = new SqlConnection(builder.ConnectionString);

            try
            {
                await db.OpenAsync();
                //MessageBox.Show("Connecté !");
                await LoadFirstData();
                return true;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Impossible de se connecter à la base de données");
                return false;
            }
        }

        public static async Task LoadFirstData()
        {
            //FAMILLES
            SqlCommand request = new SqlCommand("prc_liste_familles", db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                Famille famille = new(sqlReader["code"].ToString(), sqlReader["libelle"].ToString(), int.Parse(sqlReader["nbMediAmm"].ToString()));
                familles.Add(famille.getCode(), famille);
            }

            //MEDICAMENTS
            request = new SqlCommand("prc_liste_medicaments", db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            sqlReader = await request.ExecuteReaderAsync();

            //la derniere etape est enregistrée sur le workflow ///!!!\\\
            //    et surtout dans le constructeur on met 0 pour l'étape
            while (await sqlReader.ReadAsync())
            {
                float prixEchantillon;
                bool prixEchantillonExiste = float.TryParse(sqlReader["prixEchantillon"].ToString(), out prixEchantillon);
                Medicament medicament = new(sqlReader["depotLegal"].ToString(), sqlReader["nomCommercial"].ToString(), sqlReader["composition"].ToString(), sqlReader["effets"].ToString(), sqlReader["contreIndications"].ToString(), prixEchantillonExiste ? prixEchantillon : null, sqlReader["amm"].ToString(), 0, sqlReader["codeFamille"].ToString());
                medicaments.Add(medicament.getDepotLegal(), medicament);
            }

            //Etapes
            string sql = "SELECT ETA_NUM, ETA_LIBELLE from etape";
            request = new SqlCommand (sql, db);
            request.CommandType = System.Data.CommandType.Text;
            sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                etapes.Add(new(int.Parse(sqlReader["ETA_NUM"].ToString()), sqlReader["ETA_LIBELLE"].ToString()));
            }

            //Decisions
            sql = "SELECT DEC_ID, libelleDecision from decision";
            request = new SqlCommand(sql, db);
            request.CommandType = System.Data.CommandType.Text;
            sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                decisions.Add(new(int.Parse(sqlReader["DEC_ID"].ToString()), sqlReader["libelleDecision"].ToString()));
            }

            //Récupérer les workflows des médicaments
            sql = "SELECT WOR_ETA_NUM, WOR_DEC_ID, WOR_MED_DEPOTLEGAL, WOR_DATE_DECISION from workflow";
            request = new SqlCommand(sql, db);
            request.CommandType = System.Data.CommandType.Text;
            sqlReader = await request.ExecuteReaderAsync();

            try
            {
                while (await sqlReader.ReadAsync())
                {
                    Medicament medicament = medicaments[sqlReader["WOR_MED_DEPOTLEGAL"].ToString()];
                    medicament.AjouterEtape(new(
                        DateOnly.FromDateTime(DateTime.Parse(sqlReader["WOR_DATE_DECISION"].ToString())),
                        int.Parse(sqlReader["WOR_ETA_NUM"].ToString()),
                        int.Parse(sqlReader["WOR_DEC_ID"].ToString())
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
                    ));
        }
    }
}
