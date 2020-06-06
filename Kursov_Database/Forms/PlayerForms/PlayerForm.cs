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

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

           

            DisconnectFromDatabase();
        }
    }
}
