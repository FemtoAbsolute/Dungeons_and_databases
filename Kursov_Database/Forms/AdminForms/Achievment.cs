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
    public partial class Achievment : Form
    {
        MySqlConnection Connection;
        public Achievment()
        {
            InitializeComponent();
            ConnectToDatabase("root", "root");
            RefreshAchievementTable();
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
   
        void RefreshAchievementTable()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            ConnectToDatabase("root", "root");
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select nameofachievement from Achievementlist;", Connection);
            Adapter.Fill(Table);
            AllAchievmentsTable.DataSource = Table;
            AllAchievmentsTable.Columns[0].HeaderText = "Название достижения";
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
        object value;
        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                value = AllAchievmentsTable.Rows[e.RowIndex].Cells[0].Value;
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                DataTable Table1 = new DataTable();
                MySqlDataAdapter Adapter1;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select `InformationAbout` from `kursach_database`.Achievementlist where nameofachievement = '" + value.ToString() + "';", Connection);
                Adapter.Fill(Table);
                AchievmentLabel.Text = Table.Rows[0][0].ToString();
                Adapter1 = new MySqlDataAdapter("select `Reward` from `kursach_database`.Achievementlist where nameofachievement = '" + value.ToString() + "';", Connection);
                Adapter1.Fill(Table1);
                RewardLabel.Text = Table1.Rows[0][0].ToString();
            }
            catch
            {
                AchievmentLabel.Text = String.Empty;
                RewardLabel.Text = String.Empty;
            }
        }

        private void AddAchievmentButton_Click(object sender, EventArgs e)
        {
            AllAchievmentsTable.Columns.Clear();
            if (!(AchievmentInformationTextbox.Text == "" || AchievmentNameTextbox.Text == "" || AchievmentRewardTextbox.Text == ""))
            {
                try
                {

                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("insert into achievementlist (nameofachievement, informationabout, reward) values ('{0}','{1}','{2}');", AchievmentNameTextbox.Text, AchievmentInformationTextbox.Text, AchievmentRewardTextbox.Text);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshAchievementTable();
                    DisconnectFromDatabase();
                    AchievmentNameTextbox.Text = "";
                    AchievmentInformationTextbox.Text = "";
                    AchievmentRewardTextbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshAchievementTable();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!(AchievmentInformationTextbox.Text == "" || AchievmentNameTextbox.Text == "" || AchievmentRewardTextbox.Text == ""))
            {
                try
                {

                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("update achievementlist set nameofachievement = '{0}', informationabout = '{1}', reward = '{2}' where nameofachievement = '{3}' ", AchievmentNameTextbox.Text, AchievmentInformationTextbox.Text, AchievmentRewardTextbox.Text, value.ToString());
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshAchievementTable();
                    DisconnectFromDatabase();
                    AchievmentNameTextbox.Text = "";
                    AchievmentInformationTextbox.Text = "";
                    AchievmentRewardTextbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные");
                RefreshAchievementTable();
            }
        }
    }
}
