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
    public partial class AllClassesForm : Form
    {
        MySqlConnection Connection;
      //  int PerkIndex;
        public AllClassesForm()
        {
            this.Width = 510;
            this.Height = 392;
            InitializeComponent();
            ConnectToDatabase("root", "root");
            ShowAllPerks();
            DisconnectFromDatabase();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Adapter = new MySqlDataAdapter("select id_class, name from `kursach_database`.class;", Connection);
            Adapter.Fill(Table);
            AllClassesTable.DataSource = Table;

        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            this.Height = 477;
            AddSaveClassButton.Visible = true;
            ClassNameTextbox.Visible = true;
            ClassInformationTextbox.Visible = true;
            ChangeClassButton.Visible = true;
        }
        private void AddSaveClassButton_Click(object sender, EventArgs e)
        {

            ConnectToDatabase("root", "root");
            string commandText = String.Format("insert into `kursach_database`.class (name, information) values ('{0}','{1}');", ClassNameTextbox.Text, ClassInformationTextbox.Text);
            MySqlCommand command = new MySqlCommand(commandText, Connection);
            MySqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            dataReader.Close();
            ShowAllPerks();
            AddSaveClassButton.Visible = false;
            ClassNameTextbox.Visible = false;
            ClassInformationTextbox.Visible = false;
            ChangeClassButton.Visible = false;
            this.Width = 510;
            this.Height = 392;
            DisconnectFromDatabase();
        }


        string NameOfClass;
        string IndexOfClass;
        private void CellMouseClickClass(object sender, DataGridViewCellMouseEventArgs e)
        {
            PerksOfClassTable.Columns.Clear();
            try
            {
                IndexOfClass = AllClassesTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameOfClass = AllClassesTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                RefreshPerksTable();

            }
            catch (Exception)
            {
            }

        }

        private void AddPerkButton_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            this.Height = 477;
            ChoosePerksLabel.Visible = true;
            SaveAddPerksButton.Visible = true;
            PerksComboBox.Visible = true;
          //  ChangePerkButton.Visible = true;
        }

        private void SaveAddPerksButton_Click(object sender, EventArgs e)
        {
            
            PerksOfClassTable.Columns.Clear();
            try
            {
                    
                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("insert into `kursach_database`.perks_of_current (class_id_class, perks_id_perks) values ({0},{1});", IndexOfClass, PerksComboBox.SelectedIndex+1);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshPerksTable();
                    this.Width = 510;
                    this.Height = 392;
                    PerksOfClassTable.Columns[0].HeaderText = "Перки данного класса";
                    DisconnectFromDatabase();
                    ChoosePerksLabel.Visible = false;
                    PerksComboBox.Visible = false;
                    SaveAddPerksButton.Visible = false;
                    //ChangePerkButton.Visible = false;

            }
            catch (Exception)
            {

            }
        }
        void RefreshPerksTable()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            ConnectToDatabase("root", "root");
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select perks.name from perks_of_current inner join class on class_id_class = id_class inner join perks on perks_id_perks = id_perks WHERE CLASS.NAME = '" + NameOfClass + "'", Connection);
            Adapter.Fill(Table);
            PerksOfClassTable.DataSource = Table;
            DisconnectFromDatabase();
        }

        private void ChangeClassButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToDatabase("root", "root");
                string commandText = String.Format("update `kursach_database`.class set name = '{0}', information = '{1}' where name = '{2}';", ClassNameTextbox.Text, ClassInformationTextbox.Text, NameOfClass);
                MySqlCommand command = new MySqlCommand(commandText, Connection);
                MySqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Close();
                ShowAllPerks();
                AddSaveClassButton.Visible = false;
                ClassNameTextbox.Visible = false;
                ClassInformationTextbox.Visible = false;
                ChangeClassButton.Visible = false;
                this.Width = 510;
                this.Height = 392;
                DisconnectFromDatabase();
            }
            catch
            {

            }
        }

        private void ChangePerkButton_Click(object sender, EventArgs e)
        {
            try
            {

                ConnectToDatabase("root", "root");

                string commandText = String.Format("update `kursach_database`.perks_of_current set class_id_class = {0}, perks_id_perks = {1} WHERE id_class = {2});", IndexOfClass, PerksComboBox.SelectedIndex + 1, IndexOfClass);
                MySqlCommand command = new MySqlCommand(commandText, Connection);
                MySqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                RefreshPerksTable();
                this.Width = 510;
                this.Height = 392;
                PerksOfClassTable.Columns[0].HeaderText = "Перки данного класса";
                DisconnectFromDatabase();
                ChoosePerksLabel.Visible = false;
                PerksComboBox.Visible = false;
                SaveAddPerksButton.Visible = false;
                //ChangePerkButton.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void CellMouseClickPerk(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }

}