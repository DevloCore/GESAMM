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
            Starting();
        }

        private async void Starting()
        {
            barConnectingDb.Style = ProgressBarStyle.Marquee;

            bool dbSuccess = await Global.Init();
            if (dbSuccess)
            {
                new Menu().Show(this);
                Hide();
            }
            else
            {
                barConnectingDb.Style = ProgressBarStyle.Continuous;
                var msgBox = MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.RetryCancel);
                if(msgBox == DialogResult.Retry)
                {
                    Starting();
                }
                else Application.Exit();
            }
        }
    }
}