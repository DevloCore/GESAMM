using System.Text;
using System.Security.Cryptography;

namespace GESAMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NextState();
            Starting();
        }

        private void NextState()
        {
            bool enable = connectedAndLoaded && getUsernameInput() != "" && getPasswordInput() != "";
            buttonLogin.Enabled = enable;
        }

        private string getUsernameInput() { return tb_username.Text.Trim(); }
        private string getPasswordInput() { return tb_password.Text.Trim(); }

        private bool connectedAndLoaded = false;

        private async void Starting()
        {
            barConnectingDb.Style = ProgressBarStyle.Marquee;

            bool dbSuccess = await Global.Init();
            if (dbSuccess)
            {
                connectedAndLoaded = true;
                labelConnecting.Visible = false;
                barConnectingDb.Visible = false;
                NextState();
            }
            else
            {
                barConnectingDb.Style = ProgressBarStyle.Continuous;
                var msgBox = MessageBox.Show("Impossible de se connecter à la base de données ou erreur lors du chargement de celle-ci.", "Erreur", MessageBoxButtons.RetryCancel);
                if (msgBox == DialogResult.Retry)
                {
                    Starting();
                }
                else Application.Exit();
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            NextState();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            foreach (Utilisateur unUtil in Global.utilisateurs)
            {
                if (unUtil.getNom() == tb_username.Text && unUtil.getPassword() == tb_password.Text)
                {
                    Global.userId = unUtil.getId();
                    new Menu().Show(this);
                    Hide();
                    return;
                }
            }
            MessageBox.Show("Le nom ou le mot de passe saisi n'est pas correct.");
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            NextState();
        }
    }
}