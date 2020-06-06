using System;
using System.Windows.Forms;


namespace Kursov_Database
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "player" && LoginTextbox.Text == "player")
            {
                this.Hide();
                Kursov_Database.Forms.PlayerForms.PlayerForm PlayerForm = new Kursov_Database.Forms.PlayerForms.PlayerForm();
                PlayerForm.ShowDialog();
                this.Show();
            }
            else if (PasswordTextbox.Text == "admin" && LoginTextbox.Text == "admin")
            {
                this.Hide();
                Forms.AdminForm AdminForm = new Forms.AdminForm();
                AdminForm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль!", "Ой!");
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
