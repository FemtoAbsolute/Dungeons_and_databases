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
    public partial class CompleteQuests : Form
    {
        string idCharacter;
        MySqlConnection Connection;
        public CompleteQuests(string IDCharacter)
        {
            InitializeComponent();
            idCharacter = IDCharacter;
            ConnectToDatabase("root", "root");
            RefreshInformation();
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
        void RefreshInformation()
        {
            ConnectToDatabase("root", "root");
            DataTable Table0 = new DataTable();
            MySqlDataAdapter Adapter0;
            Table0 = new DataTable();
            Adapter0 = new MySqlDataAdapter("SELECT NameOfAchievement, InformationAbout, Reward FROM Achievements JOIN AchievementList ON AchievementList_id = id_AchievementList WHERE Character_id = " + idCharacter + ";", Connection);
            Adapter0.Fill(Table0);
            QuestsListTable.DataSource = Table0;
            QuestsListTable.Columns[1].Visible = false;
            QuestsListTable.Columns[2].Visible = false;
            DisconnectFromDatabase();
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                InfoLabel.Text = QuestsListTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                RewardLabel.Text = QuestsListTable.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch
            { 

            }
        }
    }
}
