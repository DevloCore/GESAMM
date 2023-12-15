namespace GESAMM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_password = new TextBox();
            label1 = new Label();
            buttonLogin = new Button();
            label2 = new Label();
            tb_username = new TextBox();
            labelConnecting = new Label();
            barConnectingDb = new ProgressBar();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(285, 137);
            tb_password.Margin = new Padding(3, 2, 3, 2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(161, 23);
            tb_password.TabIndex = 5;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 140);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 6;
            label1.Text = "Mot de passe";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DodgerBlue;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(173, 171);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(296, 27);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Poursuivre";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 99);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Nom d'utilisateur";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(285, 96);
            tb_username.Margin = new Padding(3, 2, 3, 2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(161, 23);
            tb_username.TabIndex = 2;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // labelConnecting
            // 
            labelConnecting.AutoSize = true;
            labelConnecting.Location = new Point(220, 200);
            labelConnecting.Name = "labelConnecting";
            labelConnecting.Size = new Size(186, 15);
            labelConnecting.TabIndex = 1;
            labelConnecting.Text = "Connexion à la base de données...";
            // 
            // barConnectingDb
            // 
            barConnectingDb.Location = new Point(204, 212);
            barConnectingDb.Margin = new Padding(3, 2, 3, 2);
            barConnectingDb.MarqueeAnimationSpeed = 30;
            barConnectingDb.Name = "barConnectingDb";
            barConnectingDb.Size = new Size(212, 16);
            barConnectingDb.Style = ProgressBarStyle.Marquee;
            barConnectingDb.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(tb_username);
            Controls.Add(labelConnecting);
            Controls.Add(barConnectingDb);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Connexion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar barConnectingDb;
        private Label labelConnecting;
        private TextBox tb_username;
        private Label label2;
        private Button buttonLogin;
        private Label label1;
        private TextBox tb_password;
    }
}