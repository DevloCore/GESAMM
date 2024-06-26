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
        public static int userId;
        public static SqlConnection db { get; private set; }

        public static Dictionary<string, Famille> familles;
        public static Dictionary<string, Medicament> medicaments;
        public static List<Etape> etapes;
        public static Dictionary<int, EtapeNormee> etapesNormees;
        public static List<Decision> decisions;
        public static List<Utilisateur> utilisateurs;

        public static async Task<bool> Init()
        {
            familles = new Dictionary<string, Famille>();
            medicaments = new Dictionary<string, Medicament>();
            etapes = new List<Etape>();
            decisions = new List<Decision>();
            utilisateurs = new List<Utilisateur>();

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
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Impossible de se connecter à la base de données");
                return false;
            }
        }

        private static async Task LoadFirstData()
        {
            try
            {

                familles = new Dictionary<string, Famille>();
                medicaments = new Dictionary<string, Medicament>();
                etapes = new List<Etape>();
                etapesNormees = new Dictionary<int, EtapeNormee>();
                decisions = new List<Decision>();
                utilisateurs = new List<Utilisateur>();

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


                while (await sqlReader.ReadAsync())
                {
                    float prixEchantillon;
                    bool prixEchantillonExiste = float.TryParse(sqlReader["prixEchantillon"].ToString(), out prixEchantillon);
                    Medicament medicament = new(sqlReader["depotLegal"].ToString(), sqlReader["nomCommercial"].ToString(), sqlReader["composition"].ToString(), sqlReader["effets"].ToString(), sqlReader["contreIndications"].ToString(), prixEchantillonExiste ? prixEchantillon : null, sqlReader["amm"].ToString(), int.Parse(sqlReader["derniereEtape"].ToString()), sqlReader["codeFamille"].ToString());
                    medicaments.Add(medicament.getDepotLegal(), medicament);
                }

                //Normes des étapes
                string sql = "SELECT ETA_NUM, NORME, DATENORME from etapenorme";
                request = new SqlCommand(sql, db);
                request.CommandType = System.Data.CommandType.Text;
                sqlReader = await request.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    int id = int.Parse(sqlReader["ETA_NUM"].ToString());
                    etapesNormees.Add(id, new(id, sqlReader["NORME"].ToString(), sqlReader["DATENORME"].ToString()));
                }

                //Etapes
                sql = "SELECT ETA_NUM, ETA_LIBELLE from etape";
                request = new SqlCommand(sql, db);
                request.CommandType = System.Data.CommandType.Text;
                sqlReader = await request.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    int id = int.Parse(sqlReader["ETA_NUM"].ToString());
                    EtapeNormee etapeNorme = etapesNormees[id];
                    bool estNormee = etapeNorme.getNorme() != "";
                    etapes.Add(new(id, sqlReader["ETA_LIBELLE"].ToString(), estNormee ? etapeNorme : null));
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

                //Utilisateurs
                sql = "SELECT id, nom, password FROM UTILISATEUR";
                request = new SqlCommand(sql, db);
                request.CommandType = System.Data.CommandType.Text;
                sqlReader = await request.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    utilisateurs.Add(new(int.Parse(sqlReader["id"].ToString()), sqlReader["nom"].ToString(), sqlReader["password"].ToString()));
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
                        ));
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public static async Task ReloadData(bool displayResult = false)
        {
            await LoadFirstData();
            if (displayResult) MessageBox.Show("Rechargement terminé");
        }
    }
}
