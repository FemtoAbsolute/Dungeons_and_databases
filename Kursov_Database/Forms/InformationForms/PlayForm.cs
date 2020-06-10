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
    public partial class PlayForm : Form
    {
        MySqlConnection Connection;
        string NameOfCharacter;
        public PlayForm(string Name)
        {
            InitializeComponent();
            NameOfCharacter = Name;

            ConnectToDatabase("root", "root");
            DrawCharacter();
            RefreshInformation();
            DisconnectFromDatabase();
            LevelBar.Minimum = 0;
            LevelBar.Maximum = 100;
            LevelBar.Step = 10;
            
        }
       
        void DrawCharacter()
        {
            ConnectToDatabase("root", "root");
            DataTable Table0 = new DataTable();
            MySqlDataAdapter Adapter0;
            Table0 = new DataTable();
            Adapter0 = new MySqlDataAdapter("select * from `kursach_database`.`Character` where id_character = '" + NameOfCharacter + "';", Connection);
            Adapter0.Fill(Table0);
            if (Table0.Rows[0][1].ToString() == "Отсутствует")
                PlayerPictureBox.Image = Kursov_Database.Properties.Resources.BossBold;
            if (Table0.Rows[0][1].ToString() == "Каре")
                PlayerPictureBox.Image = Kursov_Database.Properties.Resources.BossCare;
            if (Table0.Rows[0][1].ToString() == "Длинные волосы")
                PlayerPictureBox.Image = Kursov_Database.Properties.Resources.BossLong;
            if (Table0.Rows[0][1].ToString() == "Хвост")
                PlayerPictureBox.Image = Kursov_Database.Properties.Resources.BossTail;
            DisconnectFromDatabase();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            try
            {

                

                ConnectToDatabase("root", "root");
                DataTable Table0 = new DataTable();
                MySqlDataAdapter Adapter0;
                Table0 = new DataTable();
                Adapter0 = new MySqlDataAdapter("select * from `kursach_database`.`Character` where id_Character = '" + NameOfCharacter + "';", Connection);
                Adapter0.Fill(Table0);
                NameLabel.Text = Table0.Rows[0][2].ToString(); ;
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select Name from `kursach_database`.Class where id_class = " + Table0.Rows[0][3].ToString() + ";", Connection);
                Adapter.Fill(Table);
                ClassLabel.Text = Table.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table1 = new DataTable();
                MySqlDataAdapter Adapter1;
                Table1 = new DataTable();
                Adapter1 = new MySqlDataAdapter("select Name from `kursach_database`.fraction where id_fraction = " + Table0.Rows[0][4].ToString() + ";", Connection);
                Adapter1.Fill(Table1);
                FractionLabel.Text = Table1.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table2 = new DataTable();
                MySqlDataAdapter Adapter2;
                Table2 = new DataTable();
                Adapter2 = new MySqlDataAdapter("select Name from `kursach_database`.talents where id_talents = " + Table0.Rows[0][5].ToString() + ";", Connection);
                Adapter2.Fill(Table2);
                TalentLabel.Text = Table2.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table3 = new DataTable();
                MySqlDataAdapter Adapter3;
                Table3 = new DataTable();
                Adapter3 = new MySqlDataAdapter("select Name from `kursach_database`.profession where id_profession = " + Table0.Rows[0][7].ToString()+ ";", Connection);
                Adapter3.Fill(Table3);
                ProfessionLabel.Text = Table3.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table4 = new DataTable();
                MySqlDataAdapter Adapter4;
                Table4 = new DataTable();
                Adapter4 = new MySqlDataAdapter("SELECT Head.Gearscore, Body.Gearscore, Pants.Gearscore, Feets.Gearscore, LeftHand.Gearscore, RightHand.Gearscore FROM(SELECT * FROM SetOfArmor WHERE id_SetOfArmor = " + Table0.Rows[0][6].ToString() + ") AS TempTable JOIN Head ON TempTable.Head = Head.id_head JOIN Body ON TempTable.Body = Body.id_body JOIN Pants ON TempTable.Pants = Pants.id_Pants JOIN Feets ON TempTable.Feets = Feets.id_Feets JOIN LeftHand ON TempTable.LeftHand = LeftHand.id_LetfHand JOIN RightHand ON TempTable.RightHand = RightHand.id_RightHand;", Connection);
                Adapter4.Fill(Table4);
                int SumOfGearscore = 0;
                for (int i = 0; i < 6; i++)
                {
                    SumOfGearscore += Convert.ToInt32(Table4.Rows[0][i]);
                }
                GearscoreLabel.Text = SumOfGearscore.ToString();
                DisconnectFromDatabase();

                LevelLabel.Text = Table0.Rows[0][8].ToString();
                LevelLabelCopy.Text = Table0.Rows[0][8].ToString();
                int LevelValue = Convert.ToInt32(Table0.Rows[0][8].ToString());
                int DefINT, DefPWR, DefAGI, DefVIT, DefSTL;
                DefINT = DefPWR = DefAGI = DefVIT = DefSTL = 100;

                ConnectToDatabase("root", "root");
                DataTable Table5 = new DataTable();
                MySqlDataAdapter Adapter5;
                Table5 = new DataTable();

                Adapter5 = new MySqlDataAdapter("select Perks_id_Perks, value_of_perk from `kursach_database`.perks_of_current where class_id_Class = " + Table0.Rows[0][3].ToString() + ";", Connection);
                Adapter5.Fill(Table5);
                for (int i = 0; i < Table5.Rows.Count; i++)
                {
                    if (Table5.Rows[i][0].ToString() == "6")
                        DefAGI += Convert.ToInt32(Table5.Rows[i][1]);
                    if (Table5.Rows[i][0].ToString() == "7")
                        DefINT += Convert.ToInt32(Table5.Rows[i][1]);
                    if (Table5.Rows[i][0].ToString() == "8")
                        DefPWR += Convert.ToInt32(Table5.Rows[i][1]);
                    if (Table5.Rows[i][0].ToString() == "9")
                        DefVIT += Convert.ToInt32(Table5.Rows[i][1]);
                    if (Table5.Rows[i][0].ToString() == "10")
                        DefSTL += Convert.ToInt32(Table5.Rows[i][1]);
                }

                if (TalentLabel.Text == "Защита")
                {
                    DefVIT += 100;
                }
                if (TalentLabel.Text == "Атака")
                {
                    DefPWR += 100;
                }
                if (TalentLabel.Text == "Баланс")
                {
                    DefPWR += 50;
                    DefVIT += 50;
                }

                if (FractionLabel.Text == "Королевство Баз")
                {
                    DefINT += 100;
                }
                if (FractionLabel.Text == "Империя Сессий")
                {
                    DefPWR += 100;
                }
                if (FractionLabel.Text == "Альянс Кафедр")
                {
                    DefVIT += 100;
                }

                DefVIT += LevelValue * 10 + SumOfGearscore * 10;
                DefPWR += LevelValue * 10 + SumOfGearscore * 10;
                DefINT += LevelValue * 10 + SumOfGearscore * 10;
                DefSTL += LevelValue * 10 + SumOfGearscore * 10;
                DefAGI += LevelValue * 10 + SumOfGearscore * 10;

                StealthLabel.Text = DefSTL.ToString();
                VitalityLabel.Text = DefVIT.ToString();
                PowerLabel.Text = DefPWR.ToString();
                IntelligenceValue.Text = DefINT.ToString();
                AgilityLabel.Text = DefAGI.ToString();

                DisconnectFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        Random Rand = new Random();
        private void EnterTheDungeon_Click(object sender, EventArgs e)
        {
            ConnectToDatabase("root", "root");
            DataTable Table0 = new DataTable();
            MySqlDataAdapter Adapter0;
            Table0 = new DataTable();
            Adapter0 = new MySqlDataAdapter("select * from `kursach_database`.`Character` where id_Character = '" + NameOfCharacter + "';", Connection);
            Adapter0.Fill(Table0);
            DisconnectFromDatabase();
            bool GotCoolestWeapon = false;
            if (Table0.Rows[0][8].ToString() == "100")
            {
                if (GotCoolestWeapon == false)
                {
                    MessageBox.Show("Вот вы и достигли вершины славы! Вам была выдана самая лучшая броня в игре! Поздравляем!");
                    try
                    {

                        ConnectToDatabase("root", "root");
                        string commandText = String.Format("update SetOfArmor set Head = {0}, Body = {1}, Pants = {2}, Feets = {3}, LeftHand = {4}, RightHand = {5} where id_SetOfArmor = {6} ", 3, 2, 2, 2, 2, 2, Table0.Rows[0][6].ToString());
                        MySqlCommand command = new MySqlCommand(commandText, Connection);
                        MySqlDataReader dataReader;
                        dataReader = command.ExecuteReader();
                        RefreshInformation();
                        DisconnectFromDatabase();
                        GotCoolestWeapon = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                  
                }
            }
            else
            {
                LevelBar.PerformStep();
                if (LevelBar.Value == LevelBar.Maximum)
                {
                    LevelBar.Value = LevelBar.Minimum;
                    ConnectToDatabase("root", "root");
                    string commandText = String.Format("update `Character` set Level = {0} Where id_character = {1};", (Convert.ToInt32(Table0.Rows[0][8])+1).ToString(), NameOfCharacter);
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshInformation();
                    DisconnectFromDatabase();           
                }
                int value = Rand.Next(0, 10);
                DungeonProceed(value);
            }
        }
        void DungeonProceed(int Case)
        {
            switch (Case) {
                case 1:
                    StoryTextbox.Text += "Вы походили по подземелью, ничего не нашли, но получили немного опыта" + Environment.NewLine;
                    break;
                case 2:
                    StoryTextbox.Text += "Вы походили по подземелью, ничего не нашли, но получили немного опыта" + Environment.NewLine;
                    break;
                case 3:
                    StoryTextbox.Text += "Вы походили по подземелью, ничего не нашли, но получили немного опыта" + Environment.NewLine;
                    break;
                case 4:
                    StoryTextbox.Text += "Вы походили по подземелью, ничего не нашли, но получили немного опыта" + Environment.NewLine;
                    break;
                case 5:
                    AddRandomQuest();
                    break;
                case 6:
                    AddRandomGear();
                    break;
                case 7:
                    AddRandomGear();
                    break;
                case 8:
                    AddRandomGear();
                    break;
                case 9:
                    AddRandomQuest();
                    break;
                case 10:
                    AddRandomQuest();
                    break;
               
            }
        }


        void AddRandomGear()
        {
            int Value = Rand.Next(1, 6);
            string TableName = "";
            switch (Value)
            {
                case 1:
                    TableName = "Head";
                    break;
                case 2:
                    TableName = "Body";
                    break;
                case 3:
                    TableName = "Pants";
                    break;
                case 4:
                    TableName = "Feets";
                    break;
                case 5:
                    TableName = "LeftHand";
                    break;
                case 6:
                    TableName = "RightHand";
                    break;
            }
            DataTable Table9 = new DataTable();
            MySqlDataAdapter Adapter9;
            Table9 = new DataTable();
            Adapter9 = new MySqlDataAdapter("select * from `kursach_database`." + TableName + ";", Connection);
            Adapter9.Fill(Table9);
            DisconnectFromDatabase();
            int Value2 = Rand.Next(0, Table9.Rows.Count);
            StoryTextbox.Text += "Блуждая по подземелью вы обнаружили предмет снаряжения! Это " + Table9.Rows[Value2][1].ToString() + ". Его ГС составляет целых " + Table9.Rows[Value2][4].ToString() + " Единиц!" + Environment.NewLine;
            DialogResult Dialog = MessageBox.Show("Блуждая по подземелью вы обнаружили предмет снаряжения! Это " + Table9.Rows[Value2][1].ToString() + ". Его ГС составляет целых " + Table9.Rows[Value2][4].ToString() + " Единиц!" + Environment.NewLine + "Надеть снаряжение? В противном случае вы оставите его тут...", "Ого", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                string AllowedClass, MyClass;
               
                ConnectToDatabase("root", "root");
                DataTable Table0 = new DataTable();
                MySqlDataAdapter Adapter0;
                Table0 = new DataTable();
                Adapter0 = new MySqlDataAdapter("select * from `kursach_database`.`Character` where id_Character = '" + NameOfCharacter + "';", Connection);
                Adapter0.Fill(Table0);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table1 = new DataTable();
                MySqlDataAdapter Adapter1;
                Table1 = new DataTable();
                Adapter1 = new MySqlDataAdapter("SELECT Class.Name FROM `Character` JOIN Class on `Character`.Class = Class.id_Class WHERE id_Character = " + Table0.Rows[0][0]+ ";", Connection);
                Adapter1.Fill(Table1);
                MyClass = Table1.Rows[0][0].ToString().Substring(0, 2).ToLower();
                AllowedClass = Table9.Rows[Value2][3].ToString().ToLower();
                DisconnectFromDatabase();
                if (AllowedClass.Contains(MyClass))
                {
                    ConnectToDatabase("root", "root");

                    string commandText = String.Format("update setofarmor set {0} = {1} Where id_setofarmor = {2};", TableName, Table9.Rows[Value2][0].ToString(), Table0.Rows[0][6].ToString());
                    MySqlCommand command = new MySqlCommand(commandText, Connection);
                    MySqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    RefreshInformation();
                    DisconnectFromDatabase();
                }
                else
                    MessageBox.Show("О нет.. Похоже ты не можешь надеть это снаряжение, оно не для твоего класса");
            }
        }
        void AddRandomQuest()
        {
            DataTable Table9 = new DataTable();
            MySqlDataAdapter Adapter9;
            Table9 = new DataTable();
            Adapter9 = new MySqlDataAdapter("select * from `kursach_database`.achievementlist;", Connection);
            Adapter9.Fill(Table9);
            DisconnectFromDatabase();
            int Value2 = Rand.Next(0, Table9.Rows.Count);
            StoryTextbox.Text += "Прогуливаясь мимо таверны вы заметили записку на доске объявлений. Она гласила '" + Table9.Rows[Value2][2].ToString() + "' . Вас заинтересовало это задание и вы без труда выполнили, получив в награду " + Table9.Rows[Value2][3].ToString() + "" + Environment.NewLine;
            ConnectToDatabase("root", "root");
            string commandText = String.Format("insert into Achievements (Character_id,  AchievementList_id) values ({0}, {1});", NameOfCharacter , Table9.Rows[Value2][0].ToString());
            MySqlCommand command = new MySqlCommand(commandText, Connection);
            MySqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            DisconnectFromDatabase();
        }

        private void CompleteQuests_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.InformationForms.CompleteQuests CompleteQuests = new InformationForms.CompleteQuests(NameOfCharacter);

            CompleteQuests.ShowDialog();
            this.Show();
        }
    }
}
