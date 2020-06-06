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

namespace Kursov_Database.Forms.AdminFormsGears
{
    public partial class RightHand : Form
    {
        MySqlConnection Connection;
        public RightHand()
        {
            InitializeComponent();
            ConnectToDatabase("root", "root");
            ShowAllPerks();
            UpdateClasses();
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
            Adapter = new MySqlDataAdapter("select `Name` from `kursach_database`.RightHand;", Connection);
            Adapter.Fill(Table);
            AllGearsTable.DataSource = Table;
        }
        void RefreshGearTable()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            ConnectToDatabase("root", "root");
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select name from RightHand;", Connection);
            Adapter.Fill(Table);
            AllGearsTable.DataSource = Table;
            DisconnectFromDatabase();
        }


        //private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        var value = AllGearsTable.Rows[e.RowIndex].Cells[0].Value;
        //        DataTable Table = new DataTable();
        //        DataTable Table2 = new DataTable();
        //        DataTable Table3 = new DataTable();
        //        MySqlDataAdapter Adapter;
        //        Table = new DataTable();
        //        Adapter = new MySqlDataAdapter("select `Type` from `kursach_database`.Head where Name = '" + value.ToString() + "';", Connection);
        //        Adapter.Fill(Table);
        //        TypeLabel.Text = Table.Rows[0][0].ToString();
        //        Adapter = new MySqlDataAdapter("select `AllowedClass` from `kursach_database`.Head where Name = '" + value.ToString() + "';", Connection);
        //        Adapter.Fill(Table2);
        //        ClassLabel.Text = Table2.Rows[0][0].ToString();
        //        Adapter = new MySqlDataAdapter("select `Gearscore` from `kursach_database`.Head where Name = '" + value.ToString() + "';", Connection);
        //        Adapter.Fill(Table3);
        //        GearscoreLabel.Text = Table3.Rows[0][0].ToString();
        //    }
        //    catch
        //    {
        //        TypeLabel.Text = String.Empty;
        //        ClassLabel.Text = String.Empty;
        //        GearscoreLabel.Text = String.Empty;
        //    }
        //}



        void UpdateClasses()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from class;", Connection);
            Adapter.Fill(Table);

            for (int i = 0; i < Table.Rows.Count - 1; i++)
            {
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select name from class;", Connection);
                Adapter.Fill(Table);

                checkedListBox2.Items.Insert(i, Table.Rows[i][0].ToString());
            }

        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGearButton_Click_1(object sender, EventArgs e)
        {
            AllGearsTable.Columns.Clear();
            if (!(NameTextbox.Text == ""))
            {
                try
                {
                    string AllClasses = "";
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        AllClasses += (checkedListBox2.CheckedItems[i].ToString().Substring(0, 2) + " ");

                    }

                    ConnectToDatabase("root", "root");
                    string commandText = String.Format("insert into RightHand (Name, Type, AllowedClass, Gearscore) values ('{0}','{1}','{2}',{3});", NameTextbox.Text, checkedListBox1.CheckedItems[0], AllClasses, Convert.ToInt32(NumberTextbox.Text));
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshGearTable();
                    DisconnectFromDatabase();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshGearTable();
            }
        }

        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += ItemCheck;
            }
        }

        object value;
        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            value = AllGearsTable.Rows[e.RowIndex].Cells[0].Value;
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!(NameTextbox.Text == ""))
            {
                try
                {
                    string AllClasses = "";
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        AllClasses += (checkedListBox2.CheckedItems[i].ToString().Substring(0, 2) + " ");

                    }
                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("UPDATE RightHand  SET Name= '{0}', Type = '{1}', AllowedClass = '{2}', Gearscore = {3} where Name = '{4}';", NameTextbox.Text, checkedListBox1.CheckedItems[0], AllClasses, Convert.ToInt32(NumberTextbox.Text), value.ToString());
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshGearTable();
                    DisconnectFromDatabase();
                    NumberTextbox.Text = "";
                    NameTextbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshGearTable();
            }
        }
    }

}
