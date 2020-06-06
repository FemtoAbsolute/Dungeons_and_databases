using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kursov_Database.Forms
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();

        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPerksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.AllPerksForm AllPerksForm = new AdminForms.AllPerksForm();
            AllPerksForm.ShowDialog();
            this.Show();
        }

        private void AllClassesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.AllClassesForm AllClassesForm = new AdminForms.AllClassesForm();
            AllClassesForm.ShowDialog();
            this.Show();
        }
    }
}
