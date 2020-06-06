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
    public partial class Profession : Form
    {
        MySqlConnection Connection;
        public Profession()
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
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.profession;", Connection);
            Adapter.Fill(Table);
            AllProfessionsTable.DataSource = Table;
        }



        private void CollapseButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        object value;
        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                value = AllProfessionsTable.Rows[e.RowIndex].Cells[0].Value;
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select `Information` from `kursach_database`.profession where Name = '" + value.ToString() + "';", Connection);
                Adapter.Fill(Table);
                ProfessionLabel.Text = Table.Rows[0][0].ToString();
            }
            catch
            {
                ProfessionLabel.Text = String.Empty;
            }
        }

        private void AddProfessionButton_Click(object sender, EventArgs e)
        {
            AllProfessionsTable.Columns.Clear();
            if (!(ProfessionInformationTextbox.Text == "" || ProfessionNameTextbox.Text == ""))
            {
                try
                {

                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("insert into `kursach_database`.profession (name, information) values ('{0}','{1}');", ProfessionNameTextbox.Text, ProfessionInformationTextbox.Text);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshProfessionTable();
                    DisconnectFromDatabase();
                    ProfessionNameTextbox.Text = "";
                    ProfessionInformationTextbox.Text = "";
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshProfessionTable();
            }
        }
        void RefreshProfessionTable()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            ConnectToDatabase("root", "root");
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select name from profession;", Connection);
            Adapter.Fill(Table);
            AllProfessionsTable.DataSource = Table;
            DisconnectFromDatabase();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!(ProfessionNameTextbox.Text == "" || ProfessionInformationTextbox.Text == ""))
            {
                try
                {

                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("update Profession set name= '{0}', information = '{1}' where name = '{2}';", ProfessionNameTextbox.Text, ProfessionInformationTextbox.Text, value.ToString());
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshProfessionTable();
                    DisconnectFromDatabase();
                    ProfessionNameTextbox.Text = "";
                    ProfessionInformationTextbox.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshProfessionTable();
            }
        }
    }
}
