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
    public partial class ProceedQuerry : Form
    {
        MySqlConnection Connection;
        public ProceedQuerry()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void QuerryButton_Click(object sender, EventArgs e)
        {
            ConnectToDatabase("root", "root");
            try
            {
                string CopyQuerry = QuerryTextbox.Text.ToLower();
                if(CopyQuerry.Contains("select"))
                {
                    string commandText = String.Format(QuerryTextbox.Text);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                }
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter(QuerryTextbox.Text, Connection);
                Adapter.Fill(Table);
                QuerryDatagrid.DataSource = Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisconnectFromDatabase();
            QuerryTextbox.Text = string.Empty;
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
    }
}
