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
        public static SqlConnection db { get; private set; }

        public static Dictionary<string, Famille> familles = new Dictionary<string, Famille>();
        public static Dictionary<string, Medicament> medicaments = new Dictionary<string, Medicament>();
        public static List<Etape> etapes = new List<Etape>();
        public static List<Decision> decisions = new List<Decision>();

        public static async Task<bool> InitDatabase()
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = ".\\SQLEXPRESS";
            //builder.UserID = "<your_username>";
            //builder.Password = "<your_password>";
            builder.InitialCatalog = "GESAMM";
            builder.IntegratedSecurity = true;
            builder.TrustServerCertificate = true;
            builder.MultipleActiveResultSets = true;

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
            //il va falloir créer cette procédure mais également la 2ème pour les medicaments

            SqlCommand request = new SqlCommand("prc_listeFamilles", db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlReader = await request.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                //Ajouter une famille a la liste 'familles' dans la classe Global
            }

            //FAIRE DE MEME POUR LES MEDICAMENTS
        }
    }
}
