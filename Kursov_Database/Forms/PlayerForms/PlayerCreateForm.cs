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

namespace Kursov_Database.Forms.PlayerForms
{
    public partial class PlayerCreateForm : Form
    {
        MySqlConnection Connection;
        public PlayerCreateForm()
        {
            
            InitializeComponent();
            MessageBox.Show("Добро пожаловать в Dungeons and Databases! Прежде чем начать, давай создадим нашего персонажа!", "Добро пожаловать!");
            ConnectToDatabase("root", "root");
            UpdateClasses();
            UpdateProfessions();
            UpdateTalents();
            UpdateFractions();
            DisconnectFromDatabase();
            HairPictureBox.Visible = false;



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
        void UpdateClasses()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from class;", Connection);
            Adapter.Fill(Table);

            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select name from class;", Connection);
                Adapter.Fill(Table);

                ClassCombobox.Items.Insert(i, Table.Rows[i][0].ToString());
            }

        }
        void UpdateProfessions()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from Profession;", Connection);
            Adapter.Fill(Table);

            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select name from Profession;", Connection);
                Adapter.Fill(Table);

                ProfessionCombobox.Items.Insert(i, Table.Rows[i][0].ToString());
            }

        }
        void UpdateTalents()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from Talents;", Connection);
            Adapter.Fill(Table);

            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select name from Talents;", Connection);
                Adapter.Fill(Table);
                TalentsComboBox.Items.Insert(i, Table.Rows[i][0].ToString());
            }

        }
        void UpdateFractions()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from Fraction;", Connection);
            Adapter.Fill(Table);

            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select name from Fraction;", Connection);
                Adapter.Fill(Table);
                FractionComboBox.Items.Insert(i, Table.Rows[i][0].ToString());
            }

        }

        private void FractionIndexChanged(object sender, EventArgs e)
        {
            if (FractionComboBox.SelectedItem.ToString() == "Королевство Баз")
                BackgroundPicturebox.Image = Properties.Resources.BaseKingdom;
            if (FractionComboBox.SelectedItem.ToString() == "Империя Сессий")
                BackgroundPicturebox.Image = Properties.Resources.SessionImperium;
            if (FractionComboBox.SelectedItem.ToString() == "Альянс Кафедр")
                BackgroundPicturebox.Image = Properties.Resources.HeroDefault;
        }

        private void HairIndexChanged(object sender, EventArgs e)
        {
            if (AppearenceCombobox.SelectedItem.ToString() == "Отсутствует")
                HairPictureBox.Visible = false;
            if (AppearenceCombobox.SelectedItem.ToString() == "Длинные волосы") {
                HairPictureBox.Visible = true;
                HairPictureBox.Image = Properties.Resources.LongHair;
            }
            if (AppearenceCombobox.SelectedItem.ToString() == "Каре")
            {
                HairPictureBox.Visible = true;
                HairPictureBox.Image = Properties.Resources.CareHair;
            }
            if (AppearenceCombobox.SelectedItem.ToString() == "Хвост")
            {
                HairPictureBox.Visible = true;
                HairPictureBox.Image = Properties.Resources.TailHairt;
            }

        }

        private void TalentsIndexChanged(object sender, EventArgs e)
        {
            if (TalentsComboBox.SelectedItem.ToString() == "Защита")
            {
                Shieldpicturebox.Visible = true;
                Knifepicturebox.Visible = false;
            }
            if (TalentsComboBox.SelectedItem.ToString() == "Атака")
            { 
            Knifepicturebox.Visible = true;
            Shieldpicturebox.Visible = false;
            }
            if (TalentsComboBox.SelectedItem.ToString() == "Баланс")
            {
                Knifepicturebox.Visible = true;
                Shieldpicturebox.Visible = true;
            }
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToDatabase("root", "root");

                string commandText = String.Format("insert into `kursach_database`.setofarmor (head, body, pants, feets, lefthand, righthand) values (2, 1, 1, 1, 1, 1);");
                MySqlCommand command = new MySqlCommand(commandText, Connection);
                MySqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                DisconnectFromDatabase();
                ConnectToDatabase("root", "root");
                int NewSetOfArmor, ClassID, FractionID, TalentsID, ArmorID, ProfessionID;
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("SELECT * FROM setofarmor WHERE id_setofarmor=LAST_INSERT_ID();", Connection);
                Adapter.Fill(Table);
                NewSetOfArmor = Convert.ToInt32(Table.Rows[0][0]);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table1 = new DataTable();
                MySqlDataAdapter Adapter1;
                Table1 = new DataTable();
                Adapter1 = new MySqlDataAdapter("SELECT * FROM Profession WHERE Name = '"+ ProfessionCombobox.SelectedItem.ToString() +"';", Connection);
                Adapter1.Fill(Table1);
                ProfessionID = Convert.ToInt32(Table1.Rows[0][0]);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table2 = new DataTable();
                MySqlDataAdapter Adapter2;
                Table2 = new DataTable();
                Adapter2 = new MySqlDataAdapter("SELECT * FROM Class WHERE Name = '" + ClassCombobox.SelectedItem.ToString() + "';", Connection);
                Adapter2.Fill(Table2);
                ClassID = Convert.ToInt32(Table2.Rows[0][0]);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table3 = new DataTable();
                MySqlDataAdapter Adapter3;
                Table3 = new DataTable();
                Adapter3 = new MySqlDataAdapter("SELECT * FROM Fraction WHERE Name = '" + FractionComboBox.SelectedItem.ToString() + "';", Connection);
                Adapter3.Fill(Table3);
                FractionID = Convert.ToInt32(Table3.Rows[0][0]);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table4 = new DataTable();
                MySqlDataAdapter Adapter4;
                Table4 = new DataTable();
                Adapter4 = new MySqlDataAdapter("SELECT * FROM Talents WHERE Name = '" + TalentsComboBox.SelectedItem.ToString() + "';", Connection);
                Adapter4.Fill(Table4);
                TalentsID = Convert.ToInt32(Table4.Rows[0][0]);
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                string commandText1 = String.Format("insert into `kursach_database`.character (appearence, name, class, fraction, talents, armor, profession, level) values ('{0}', '{1}', {2}, {3}, {4}, {5}, {6}, 0);", AppearenceCombobox.SelectedItem.ToString(), NameTextbox.Text, ClassID, FractionID, TalentsID, NewSetOfArmor, ProfessionID);
                MySqlCommand command1 = new MySqlCommand(commandText1, Connection);
                MySqlDataReader dataReader1;
                dataReader1 = command1.ExecuteReader();
                DisconnectFromDatabase();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void ShowPerksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.AllPerksForm AllPerksForm = new AdminForms.AllPerksForm();
            AllPerksForm.ShowDialog();
            this.Show();
        }

        private void ShowAllTalents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Talents Talents = new AdminForms.Talents();
            Talents.ShowDialog();
            this.Show();
        }

        private void ShowAllFractions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.Fractions Fractions = new AdminForms.Fractions();
            Fractions.ShowDialog();
            this.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = string.Empty;
            SearchResultLabel.Text = string.Empty;
            string QuerryPerk = "";
            try {
                if (PerksCombobox.SelectedItem.ToString() == "Интеллекту")
                {
                    ResultLabel.Text = "Хочешь быть умнее? Выбирай:";
                    QuerryPerk = "Интеллект";

                }
                if (PerksCombobox.SelectedItem.ToString() == "Здоровью")
                {
                    QuerryPerk = "Здоровье";
                    ResultLabel.Text = "Хочешь быть выносливее? Выбирай:";
                }

                if (PerksCombobox.SelectedItem.ToString() == "Силе")
                {
                    ResultLabel.Text = "Хочешь быть сильнее? Выбирай:";
                    QuerryPerk = "Сила";
                }
                if (PerksCombobox.SelectedItem.ToString() == "Скрытности")
                {
                    QuerryPerk = "Скрытность";
                    ResultLabel.Text = "Хочешь быть незаметнее? Выбирай:";
                }
                if (PerksCombobox.SelectedItem.ToString() == "Скорости")
                {
                    QuerryPerk = "Ловкость";
                    ResultLabel.Text = "Хочешь быть быстрее? Выбирай:";
                }

                if (ListCombobox.SelectedItem.ToString() == "Фракций")
                {
                    if (PerksCombobox.SelectedItem.ToString() == "Интеллекту" && Convert.ToInt32(ValueTextbox.Text) <= 100)
                        SearchResultLabel.Text = "Королевство Баз - твой выбор. Получишь сразу +100 к Интеллекту!";
                    else if (PerksCombobox.SelectedItem.ToString() == "Силе" && Convert.ToInt32(ValueTextbox.Text) <= 100)
                        SearchResultLabel.Text = "Империя сессий - твой выбор. Получишь сразу +100 к Силе!";
                    else  if (PerksCombobox.SelectedItem.ToString() == "Здоровью" && Convert.ToInt32(ValueTextbox.Text) <= 100)
                        SearchResultLabel.Text = "Альянс Кафедр - твой выбор. Получишь сразу +100 к Здоровью!";
                    else
                        SearchResultLabel.Text = "Ничего не найдено";
                }
                

                if (ListCombobox.SelectedItem.ToString() == "Талантов")
                {
                    if (PerksCombobox.SelectedItem.ToString() == "Силе" && Convert.ToInt32(ValueTextbox.Text) <= 100 && Convert.ToInt32(ValueTextbox.Text) >= 50)
                        SearchResultLabel.Text = "Выбрав талант атаки ты получишь +100 к силе";
                    else if (PerksCombobox.SelectedItem.ToString() == "Силе" && Convert.ToInt32(ValueTextbox.Text) <= 50)
                        SearchResultLabel.Text = "Ты можешь выбрать таланты Атаки или Баланса, получив +100 и +50 к силе соответственно";

                    else if (PerksCombobox.SelectedItem.ToString() == "Здоровью" && Convert.ToInt32(ValueTextbox.Text) <= 100 && Convert.ToInt32(ValueTextbox.Text) >= 50)
                        SearchResultLabel.Text = "Выбрав талант защиты ты получишь +100 к здоровью";
                    else if (PerksCombobox.SelectedItem.ToString() == "Здоровью" && Convert.ToInt32(ValueTextbox.Text) <= 50)
                        SearchResultLabel.Text = "Ты можешь выбрать таланты Защиты или Баланса, получив +100 и +50 к здоровью соответственно";
                    else
                        SearchResultLabel.Text = "Ничего не найдено";
                }


                if (ListCombobox.SelectedItem.ToString() == "Классов")
                {
                    ConnectToDatabase("root", "root");
                    DataTable Table = new DataTable();
                    MySqlDataAdapter Adapter;
                    Table = new DataTable();
                    Adapter = new MySqlDataAdapter("SELECT value_of_perk, class.name FROM Perks_of_current JOIN Perks ON perks_id_perks = id_perks JOIN Class ON class_id_class = id_class WHERE perks.Name = '"+ QuerryPerk +"' AND value_of_perk >"+ ValueTextbox.Text +";", Connection);
                    Adapter.Fill(Table);
                    string AllAvaliableClasses = "";
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        AllAvaliableClasses += Table.Rows[i][1].ToString() + "- +" + Table.Rows[i][0].ToString() +" "+ QuerryPerk + Environment.NewLine;
                    }
                    SearchResultLabel.Text = AllAvaliableClasses;
                    DisconnectFromDatabase();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowClassesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.AdminForms.AllClassesOnlyShow AllClacces = new AdminForms.AllClassesOnlyShow();
            AllClacces.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.InformationForms.AllProfessionForms AllProfessions = new InformationForms.AllProfessionForms();
            AllProfessions.ShowDialog();
            this.Show();
        }
    }
}
