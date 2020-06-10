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
    public partial class PlayerForm : Form
    {
        MySqlConnection Connection;
        public PlayerForm()
        {
            InitializeComponent();
            ConnectToDatabase("root", "root");
            RefreshNames();
            DisconnectFromDatabase();
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.PlayerForms.PlayerCreateForm PlayerCreateForm = new PlayerCreateForm();
            PlayerCreateForm.ShowDialog();
            this.Show();
            RefreshNames();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void RefreshNames()
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter;
            Table = new DataTable();
            Adapter = new MySqlDataAdapter("select * from `kursach_database`.Character;", Connection);
            Adapter.Fill(Table);
            NamesTable.DataSource = Table;
            NamesTable.Columns[2].HeaderText = "Имена всех персонажей";
            for (int i = 0; i < NamesTable.Columns.Count; i++)
            {
                NamesTable.Columns[i].Visible = false;
            }
            NamesTable.Columns[2].Visible = true;
            NamesTable.RowHeadersVisible = false;
            NamesTable.AllowUserToAddRows = false;
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
        int NameIndex;
        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value3 = NamesTable.Rows[e.RowIndex].Cells[5].Value;
                if (value3.ToString() == "1")
                {
                    Shieldpicturebox.Visible = true;
                    Knifepicturebox.Visible = false;
                }
                if (value3.ToString() == "2")
                {
                    Knifepicturebox.Visible = true;
                    Shieldpicturebox.Visible = false;
                }
                if (value3.ToString() == "3")
                {
                    Knifepicturebox.Visible = true;
                    Shieldpicturebox.Visible = true;
                }
                var value2 = NamesTable.Rows[e.RowIndex].Cells[1].Value;
                if (value2.ToString() == "Отсутствует")
                    HairPictureBox.Visible = false;
                if (value2.ToString() == "Длинные волосы")
                {
                    HairPictureBox.Visible = true;
                    HairPictureBox.Image = Properties.Resources.LongHair;
                }
                if (value2.ToString() == "Каре")
                {
                    HairPictureBox.Visible = true;
                    HairPictureBox.Image = Properties.Resources.CareHair;

                }
                if (value2.ToString() == "Хвост")
                {
                    HairPictureBox.Visible = true;
                    HairPictureBox.Image = Properties.Resources.TailHairt;
                }
                pictureBox1.Visible = true;
                BackgroundPicturebox.Visible = true;
                var value = NamesTable.Rows[e.RowIndex].Cells[4].Value;
                if (value.ToString() == "1")
                    BackgroundPicturebox.Image = Properties.Resources.BaseKingdom;
                if (value.ToString() == "2")
                    BackgroundPicturebox.Image = Properties.Resources.SessionImperium;
                if (value.ToString() == "3")
                    BackgroundPicturebox.Image = Properties.Resources.HeroDefault;
                DrawAStats(e.RowIndex);
                NameIndex = e.RowIndex;
            }
            catch
            {

            }
        }
        void DrawAStats(int Index) 
        {
            try
            {
                
                NameLabel.Text = NamesTable.Rows[Index].Cells[2].Value.ToString();

                ConnectToDatabase("root", "root");
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter;
                Table = new DataTable();
                Adapter = new MySqlDataAdapter("select Name from `kursach_database`.Class where id_class = " + NamesTable.Rows[Index].Cells[3].Value + ";", Connection);
                Adapter.Fill(Table);
                ClassLabel.Text = Table.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table1 = new DataTable();
                MySqlDataAdapter Adapter1;
                Table1 = new DataTable();
                Adapter1 = new MySqlDataAdapter("select Name from `kursach_database`.fraction where id_fraction = " + NamesTable.Rows[Index].Cells[4].Value + ";", Connection);
                Adapter1.Fill(Table1);
                FractionLabel.Text = Table1.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table2 = new DataTable();
                MySqlDataAdapter Adapter2;
                Table2 = new DataTable();
                Adapter2 = new MySqlDataAdapter("select Name from `kursach_database`.talents where id_talents = " + NamesTable.Rows[Index].Cells[5].Value + ";", Connection);
                Adapter2.Fill(Table2);
                TalentLabel.Text = Table2.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table3 = new DataTable();
                MySqlDataAdapter Adapter3;
                Table3 = new DataTable();
                Adapter3 = new MySqlDataAdapter("select Name from `kursach_database`.profession where id_profession = " + NamesTable.Rows[Index].Cells[7].Value + ";", Connection);
                Adapter3.Fill(Table3);
                ProfessionLabel.Text = Table3.Rows[0][0].ToString();
                DisconnectFromDatabase();

                ConnectToDatabase("root", "root");
                DataTable Table4 = new DataTable();
                MySqlDataAdapter Adapter4;
                Table4 = new DataTable();
                Adapter4 = new MySqlDataAdapter("SELECT Head.Gearscore, Body.Gearscore, Pants.Gearscore, Feets.Gearscore, LeftHand.Gearscore, RightHand.Gearscore FROM(SELECT * FROM SetOfArmor WHERE id_SetOfArmor = "+ NamesTable.Rows[Index].Cells[6].Value + ") AS TempTable JOIN Head ON TempTable.Head = Head.id_head JOIN Body ON TempTable.Body = Body.id_body JOIN Pants ON TempTable.Pants = Pants.id_Pants JOIN Feets ON TempTable.Feets = Feets.id_Feets JOIN LeftHand ON TempTable.LeftHand = LeftHand.id_LetfHand JOIN RightHand ON TempTable.RightHand = RightHand.id_RightHand;", Connection);
                Adapter4.Fill(Table4);
                int SumOfGearscore = 0;
                for (int i = 0; i < 6; i++)
                {
                    SumOfGearscore += Convert.ToInt32(Table4.Rows[0][i]);
                }
                GearscoreLabel.Text = SumOfGearscore.ToString();
                DisconnectFromDatabase();

                LevelLabel.Text = NamesTable.Rows[Index].Cells[8].Value.ToString();
                int LevelValue = Convert.ToInt32(NamesTable.Rows[Index].Cells[8].Value);
                int DefINT, DefPWR, DefAGI, DefVIT, DefSTL;
                DefINT = DefPWR = DefAGI = DefVIT = DefSTL = 100;

                ConnectToDatabase("root", "root");
                DataTable Table5 = new DataTable();
                MySqlDataAdapter Adapter5;
                Table5 = new DataTable();

                Adapter5 = new MySqlDataAdapter("select Perks_id_Perks, value_of_perk from `kursach_database`.perks_of_current where class_id_Class = " + NamesTable.Rows[Index].Cells[3].Value + ";", Connection);
                Adapter5.Fill(Table5);
                for (int i = 0; i< Table5.Rows.Count; i++)
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
                DefAGI += LevelValue * 10 +SumOfGearscore * 10;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EnterTheGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.InformationForms.PlayForm PlayForm = new InformationForms.PlayForm(NamesTable.Rows[NameIndex].Cells[0].Value.ToString());

            PlayForm.ShowDialog();
            this.Show();
            
        }
    }
}
