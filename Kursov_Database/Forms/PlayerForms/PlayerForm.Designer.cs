namespace Kursov_Database.Forms.PlayerForms
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainFormDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CreateCharacterButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.NamesTable = new System.Windows.Forms.DataGridView();
            this.Shieldpicturebox = new System.Windows.Forms.PictureBox();
            this.Knifepicturebox = new System.Windows.Forms.PictureBox();
            this.HairPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackgroundPicturebox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shieldpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knifepicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HairPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormDragControl
            // 
            this.MainFormDragControl.TargetControl = null;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightGray;
            this.TopPanel.Controls.Add(this.CollapseButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(951, 39);
            this.TopPanel.TabIndex = 9;
            // 
            // CollapseButton
            // 
            this.CollapseButton.AnimationHoverSpeed = 0.07F;
            this.CollapseButton.AnimationSpeed = 0.03F;
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BaseColor = System.Drawing.Color.Gold;
            this.CollapseButton.BorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CollapseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CollapseButton.CheckedImage = null;
            this.CollapseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CollapseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CollapseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CollapseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollapseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CollapseButton.Image = null;
            this.CollapseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CollapseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.Location = new System.Drawing.Point(897, 12);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CollapseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CollapseButton.OnHoverImage = null;
            this.CollapseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CollapseButton.Radius = 10;
            this.CollapseButton.Size = new System.Drawing.Size(18, 17);
            this.CollapseButton.TabIndex = 22;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BaseColor = System.Drawing.Color.Red;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(921, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Radius = 10;
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 21;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // CreateCharacterButton
            // 
            this.CreateCharacterButton.AnimationHoverSpeed = 0.07F;
            this.CreateCharacterButton.AnimationSpeed = 0.03F;
            this.CreateCharacterButton.BaseColor = System.Drawing.Color.Goldenrod;
            this.CreateCharacterButton.BorderColor = System.Drawing.Color.Black;
            this.CreateCharacterButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CreateCharacterButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CreateCharacterButton.CheckedForeColor = System.Drawing.Color.White;
            this.CreateCharacterButton.CheckedImage = null;
            this.CreateCharacterButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CreateCharacterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateCharacterButton.FocusedColor = System.Drawing.Color.Empty;
            this.CreateCharacterButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.CreateCharacterButton.ForeColor = System.Drawing.Color.White;
            this.CreateCharacterButton.Image = null;
            this.CreateCharacterButton.ImageSize = new System.Drawing.Size(52, 52);
            this.CreateCharacterButton.LineColor = System.Drawing.Color.MediumSeaGreen;
            this.CreateCharacterButton.Location = new System.Drawing.Point(670, 506);
            this.CreateCharacterButton.Name = "CreateCharacterButton";
            this.CreateCharacterButton.OnHoverBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.CreateCharacterButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateCharacterButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateCharacterButton.OnHoverImage = null;
            this.CreateCharacterButton.OnHoverLineColor = System.Drawing.Color.MediumSeaGreen;
            this.CreateCharacterButton.OnPressedColor = System.Drawing.Color.Black;
            this.CreateCharacterButton.Size = new System.Drawing.Size(269, 41);
            this.CreateCharacterButton.TabIndex = 10;
            this.CreateCharacterButton.Text = "Создать персонажа";
            this.CreateCharacterButton.Click += new System.EventHandler(this.CreateCharacterButton_Click);
            // 
            // NamesTable
            // 
            this.NamesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NamesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NamesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NamesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NamesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.NamesTable.Location = new System.Drawing.Point(670, 45);
            this.NamesTable.Name = "NamesTable";
            this.NamesTable.ReadOnly = true;
            this.NamesTable.Size = new System.Drawing.Size(269, 455);
            this.NamesTable.TabIndex = 11;
            this.NamesTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
            // 
            // Shieldpicturebox
            // 
            this.Shieldpicturebox.Image = global::Kursov_Database.Properties.Resources.Protec;
            this.Shieldpicturebox.Location = new System.Drawing.Point(392, 334);
            this.Shieldpicturebox.Name = "Shieldpicturebox";
            this.Shieldpicturebox.Size = new System.Drawing.Size(36, 63);
            this.Shieldpicturebox.TabIndex = 52;
            this.Shieldpicturebox.TabStop = false;
            this.Shieldpicturebox.Visible = false;
            // 
            // Knifepicturebox
            // 
            this.Knifepicturebox.Image = global::Kursov_Database.Properties.Resources.Attac;
            this.Knifepicturebox.Location = new System.Drawing.Point(516, 305);
            this.Knifepicturebox.Name = "Knifepicturebox";
            this.Knifepicturebox.Size = new System.Drawing.Size(40, 92);
            this.Knifepicturebox.TabIndex = 51;
            this.Knifepicturebox.TabStop = false;
            this.Knifepicturebox.Visible = false;
            // 
            // HairPictureBox
            // 
            this.HairPictureBox.BackColor = System.Drawing.Color.White;
            this.HairPictureBox.Location = new System.Drawing.Point(442, 291);
            this.HairPictureBox.Name = "HairPictureBox";
            this.HairPictureBox.Size = new System.Drawing.Size(85, 63);
            this.HairPictureBox.TabIndex = 50;
            this.HairPictureBox.TabStop = false;
            this.HairPictureBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kursov_Database.Properties.Resources.HeroDefault_copy;
            this.pictureBox1.Location = new System.Drawing.Point(416, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 188);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BackgroundPicturebox
            // 
            this.BackgroundPicturebox.Image = global::Kursov_Database.Properties.Resources.BaseKingdom;
            this.BackgroundPicturebox.Location = new System.Drawing.Point(326, 45);
            this.BackgroundPicturebox.Name = "BackgroundPicturebox";
            this.BackgroundPicturebox.Size = new System.Drawing.Size(296, 468);
            this.BackgroundPicturebox.TabIndex = 48;
            this.BackgroundPicturebox.TabStop = false;
            this.BackgroundPicturebox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 510);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Shieldpicturebox);
            this.Controls.Add(this.Knifepicturebox);
            this.Controls.Add(this.HairPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NamesTable);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BackgroundPicturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NamesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shieldpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knifepicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HairPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDragControl MainFormDragControl;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceTileButton CreateCharacterButton;
        private System.Windows.Forms.DataGridView NamesTable;
        private System.Windows.Forms.PictureBox Shieldpicturebox;
        private System.Windows.Forms.PictureBox Knifepicturebox;
        private System.Windows.Forms.PictureBox HairPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BackgroundPicturebox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}