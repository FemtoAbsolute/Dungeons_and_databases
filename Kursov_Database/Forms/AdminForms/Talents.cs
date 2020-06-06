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
    public partial class Talents : Form
    {
        MySqlConnection Connection;
        public Talents()
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
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.talents;", Connection);
            Adapter.Fill(Table);
            AllTalentsTable.DataSource = Table;
            AllTalentsTable.Columns[0].HeaderText = "Название таланта";
        }

 

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value = AllTalentsTable.Rows[e.RowIndex].Cells[0].Value;
                if (value.ToString() == "Защита")
                    TalentsLabel.Text = "Навыки, направленные на защиту вас и ваших союзников";
                if (value.ToString() == "Атака")
                    TalentsLabel.Text = "Увеличение урона от всех типов атак, атакующие способности и другое";
                if (value.ToString() == "Баланс")
                    TalentsLabel.Text = "Навыки, которые не усиливают что-то одно, а удерживают баланс между достойной атакой и защитой";
            }
            catch
            {
                TalentsLabel.Text = String.Empty;
            }
        }
    }
}
