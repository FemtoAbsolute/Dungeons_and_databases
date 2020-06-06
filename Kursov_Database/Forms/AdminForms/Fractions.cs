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
    public partial class Fractions : Form
    {
        MySqlConnection Connection;
        public Fractions()
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
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.fraction;", Connection);
            Adapter.Fill(Table);
            AllFractionsTable.DataSource = Table;
            AllFractionsTable.Columns[0].HeaderText = "Название фракций";
        }



        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value = AllFractionsTable.Rows[e.RowIndex].Cells[0].Value;
                if (value.ToString() == "Королевство Баз")
                    FractionsLabel.Text = "Фракция, известная своим мудрым правителем, строгой дисциплиной и прочными связями с другими фракциями.";
                if (value.ToString() == "Империя Сессий")
                    FractionsLabel.Text = "Фракция с жестоким деспотом во главе. Главным законом у них является разрушения и хаос.";
                if (value.ToString() == "Альянс Кафедр")
                    FractionsLabel.Text = "Совершенно мирная фракция, стремящаяся помочь каждому заблудшему путнику";
            }
            catch
            {
                FractionsLabel.Text = String.Empty;
            }
        }
    }
}
