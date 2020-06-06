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

        private void QuerryButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Внимание, этот пункт меню разрешено использовать только главному администратору. Использования данной кнопки некомпетентному лицу строго запрещено! Вы хотите продолжить?", "Осторожно!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Forms.AdminForms.ProceedQuerry ProceedQuerry = new AdminForms.ProceedQuerry();
                ProceedQuerry.ShowDialog();
                this.Show();
            }
        }

        private void ShowAllFractions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Fractions Fractions= new AdminForms.Fractions();
            Fractions.ShowDialog();
            this.Show();
        }

        private void ShowAllTalents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Talents Talents = new AdminForms.Talents();
            Talents.ShowDialog();
            this.Show();
        }

        private void ProfessionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Profession Profession = new AdminForms.Profession();
            Profession.ShowDialog();
            this.Show();
        }

        private void AddAchievmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Achievment Achievment = new AdminForms.Achievment();
            Achievment.ShowDialog();
            this.Show();
        }

        private void AddHeadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.HeadForm HeadForm = new AdminFormsGears.HeadForm();
            HeadForm.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.Pants PantsForm = new AdminFormsGears.Pants();
            PantsForm.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.Body BodyForm = new AdminFormsGears.Body();
            BodyForm.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.Feets FeetsForm = new AdminFormsGears.Feets();
            FeetsForm.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.RightHand RightHand = new AdminFormsGears.RightHand();
            RightHand.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminFormsGears.LeftHand LeftHand = new AdminFormsGears.LeftHand();
            LeftHand.ShowDialog();
            this.Show();
        }

        private void ShowClassesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.AllClassesOnlyShow allClassesOnlyShow = new AdminForms.AllClassesOnlyShow();
            allClassesOnlyShow.ShowDialog();
            this.Show();
        }
    }
}
