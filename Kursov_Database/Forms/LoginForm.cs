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
            if (PasswordTextbox.Text == "123" && LoginTextbox.Text == "Player")
            {
                this.Hide();
                Kursov_Database.CharactersForm CharactersForm = new Kursov_Database.CharactersForm();
                CharactersForm.ShowDialog();
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
