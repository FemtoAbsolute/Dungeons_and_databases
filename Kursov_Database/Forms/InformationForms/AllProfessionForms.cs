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

namespace Kursov_Database.Forms.InformationForms
{
    public partial class AllProfessionForms: Form
    {
        MySqlConnection Connection;
        public AllProfessionForms()
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
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.Profession;", Connection);
            Adapter.Fill(Table);
            AllFractionsTable.DataSource = Table;
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
                var value = AllFractionsTable.Rows[e.RowIndex].Cells[0].Value;
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select `Information` from `kursach_database`.Profession where Name = '" + value.ToString() + "';", Connection);
                Adapter.Fill(Table);

                FractionsLabel.Text = Table.Rows[0][0].ToString();
            }
            catch
            {
                FractionsLabel.Text = String.Empty;
            }
        }
    }
}
