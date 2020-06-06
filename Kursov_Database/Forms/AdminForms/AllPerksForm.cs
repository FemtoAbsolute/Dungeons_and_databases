using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursov_Database.Forms.AdminForms
{
    public partial class AllPerksForm : Form
    {
        MySqlConnection Connection;
        public AllPerksForm()
        {
            InitializeComponent();
            ConnectToDatabase("root", "root");
            ShowAllPerks();
            DisconnectFromDatabase();
        }
        private bool ConnectToDatabase(string Login, string Password)
        {

            string connect = String.Format("Server=127.0.0.1;Port=3306;Database=kursach_database;Uid={0};Pwd={1};", Login, Password);

            try
            {
                Connection = new MySqlConnection(connect);
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private bool DisconnectFromDatabase()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        void ShowAllPerks()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.perks;", Connection);
            Adapter.Fill(Table);
            AllPerksTable.DataSource = Table;
            AllPerksTable.Columns[0].HeaderText = "Название перка";
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            { 
            var value = AllPerksTable.Rows[e.RowIndex].Cells[0].Value;
            if (value.ToString() == "Ловкость")
                PerksLabel.Text = "Ловкость. Добавление этого перка даст бонус к скорости, уворотам и парированию";
            if (value.ToString() == "Интеллект")
                PerksLabel.Text = "Интеллект. Добавление этого перка даст бонус к урону от магии и запасу маны";
            if (value.ToString() == "Сила")
                PerksLabel.Text = "Сила. Добавление этого перка даст бонус силе, физическим атакам и выносливости";
            if (value.ToString() == "Здоровье")
                PerksLabel.Text = "Здоровье. Добавление этого перка даст бонус к запасу здоровья";
            if (value.ToString() == "Скрытность")
                PerksLabel.Text = "Скрытность. Добавление этого перка даст бонус к скрытности, уворотам и добивающим атакам";
            }
            catch
            {
                PerksLabel.Text = String.Empty;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
