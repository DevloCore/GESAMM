using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public static class Global
    {
        public static string username;
        public static SqlConnection db { get; private set; }

        public static Dictionary<string, Famille> familles;
        public static Dictionary<string, Medicament> medicaments;
        public static List<Etape> etapes;
        public static List<Decision> decisions;

        public static async Task<bool> Init()
        {
            familles = new Dictionary<string, Famille>();
            medicaments = new Dictionary<string, Medicament>();
            etapes = new List<Etape>();
            decisions = new List<Decision>();

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
            SqlCommand request = new SqlCommand("prc_liste_familles", db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                Famille famille = new(sqlReader["code"].ToString(), sqlReader["libelle"].ToString(), int.Parse(sqlReader["nbMediAmm"].ToString()));
                familles.Add(famille.getCode(), famille);
            }

            //FAIRE DE MEME POUR LES MEDICAMENTS

            request = new SqlCommand("prc_liste_medicaments", db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                Medicament medicament = new(sqlReader["depotLegal"].ToString(), sqlReader["nomCommercial"].ToString(), sqlReader["composition"].ToString(), sqlReader["effets"].ToString(), sqlReader["contreIndications"].ToString(), sqlReader["amm"].ToString(), 0, sqlReader["codeFamille"].ToString());
                medicaments.Add(medicament.getDepotLegal(), medicament);
            }
        }
    }
}
