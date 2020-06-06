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
            InitializeComponent();
  
            this.Width = 624;
            this.Height = 472;

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
            AllClassesTable.Columns[0].Visible = false;
            AllClassesTable.Columns[1].HeaderText = "Все классы";

        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            this.Width = 624;
            this.Height = 605;
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
            this.Width = 624;
            this.Height = 472;
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
            
            this.Width = 624;
            this.Height = 605;
            ChoosePerksLabel.Visible = true;
            SaveAddPerksButton.Visible = true;
            PerksComboBox.Visible = true;
            ValueTextbox.Visible = true;
          //  ChangePerkButton.Visible = true;
        }

        private void SaveAddPerksButton_Click(object sender, EventArgs e)
        {
            
            PerksOfClassTable.Columns.Clear();
            try
            {
                    
                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("insert into `kursach_database`.perks_of_current (class_id_class, perks_id_perks, value_of_perk) values ({0},{1},{2});", IndexOfClass, PerksComboBox.SelectedIndex+6, ValueTextbox.Text);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshPerksTable();
                    this.Width = 624;
                    this.Height = 472;
                    PerksOfClassTable.Columns[0].HeaderText = "Перки данного класса";
                    DisconnectFromDatabase();
                    ChoosePerksLabel.Visible = false;
                    PerksComboBox.Visible = false;
                    SaveAddPerksButton.Visible = false;
                    ValueTextbox.Visible = false;
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
            PerksOfClassTable.Columns[0].HeaderText = "Перки данного класса";
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
                this.Width = 624;
                this.Height = 472;
                DisconnectFromDatabase();
            }
            catch
            {

            }
        }

        //private void changeperkbutton_click(object sender, eventargs e)
        //{
        //    try
        //    {

        //        connecttodatabase("root", "root");

        //        string commandtext = string.format("update `kursach_database`.perks_of_current set class_id_class = {0}, perks_id_perks = {1} where id_class = {2});", indexofclass, perkscombobox.selectedindex + 1, indexofclass);
        //        mysqlcommand command = new mysqlcommand(commandtext, connection);
        //        mysqldatareader datareader;
        //        datareader = command.executereader();
        //        refreshperkstable();
        //        this.width = 624;
        //        this.height = 472;
        //        perksofclasstable.columns[0].headertext = "перки данного класса";
        //        disconnectfromdatabase();
        //        chooseperkslabel.visible = false;
        //        perkscombobox.visible = false;
        //        saveaddperksbutton.visible = false;
        //        changeperkbutton.visible = false;
        //    }
        //    catch (exception)
        //    {

        //    }
        //}

        private void CellMouseClickPerk(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }

}