namespace Kursov_Database.Forms.AdminForms
{
    partial class AllClassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllClassesForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AllClassesTable = new System.Windows.Forms.DataGridView();
            this.PerksOfClassTable = new System.Windows.Forms.DataGridView();
            this.AddSaveClassButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ClassNameTextbox = new System.Windows.Forms.TextBox();
            this.AddClassButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddPerkButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SaveAddPerksButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PerksComboBox = new System.Windows.Forms.ComboBox();
            this.ChoosePerksLabel = new System.Windows.Forms.Label();
            this.ClassInformationTextbox = new System.Windows.Forms.TextBox();
            this.ChangeClassButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllClassesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerksOfClassTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.CollapseButton.Location = new System.Drawing.Point(456, 12);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CollapseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CollapseButton.OnHoverImage = null;
            this.CollapseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CollapseButton.Radius = 10;
            this.CollapseButton.Size = new System.Drawing.Size(18, 17);
            this.CollapseButton.TabIndex = 24;
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
            this.CloseButton.Location = new System.Drawing.Point(480, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Radius = 10;
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TopPanel.Controls.Add(this.CollapseButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(512, 35);
            this.TopPanel.TabIndex = 3;
            // 
            // AllClassesTable
            // 
            this.AllClassesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllClassesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllClassesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllClassesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClassesTable.Location = new System.Drawing.Point(12, 41);
            this.AllClassesTable.Name = "AllClassesTable";
            this.AllClassesTable.ReadOnly = true;
            this.AllClassesTable.Size = new System.Drawing.Size(243, 286);
            this.AllClassesTable.TabIndex = 4;
            this.AllClassesTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClickClass);
            // 
            // PerksOfClassTable
            // 
            this.PerksOfClassTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerksOfClassTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PerksOfClassTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PerksOfClassTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerksOfClassTable.Location = new System.Drawing.Point(258, 41);
            this.PerksOfClassTable.Name = "PerksOfClassTable";
            this.PerksOfClassTable.ReadOnly = true;
            this.PerksOfClassTable.Size = new System.Drawing.Size(240, 286);
            this.PerksOfClassTable.TabIndex = 5;
            this.PerksOfClassTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClickPerk);
            // 
            // AddSaveClassButton
            // 
            this.AddSaveClassButton.AnimationHoverSpeed = 0.07F;
            this.AddSaveClassButton.AnimationSpeed = 0.03F;
            this.AddSaveClassButton.BaseColor = System.Drawing.Color.Silver;
            this.AddSaveClassButton.BorderColor = System.Drawing.Color.Black;
            this.AddSaveClassButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddSaveClassButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddSaveClassButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddSaveClassButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddSaveClassButton.CheckedImage")));
            this.AddSaveClassButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddSaveClassButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddSaveClassButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddSaveClassButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddSaveClassButton.ForeColor = System.Drawing.Color.Black;
            this.AddSaveClassButton.Image = null;
            this.AddSaveClassButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddSaveClassButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddSaveClassButton.Location = new System.Drawing.Point(278, 411);
            this.AddSaveClassButton.Name = "AddSaveClassButton";
            this.AddSaveClassButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddSaveClassButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddSaveClassButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddSaveClassButton.OnHoverImage = null;
            this.AddSaveClassButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddSaveClassButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddSaveClassButton.Size = new System.Drawing.Size(220, 25);
            this.AddSaveClassButton.TabIndex = 6;
            this.AddSaveClassButton.Text = "Добавить класс";
            this.AddSaveClassButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddSaveClassButton.Visible = false;
            this.AddSaveClassButton.Click += new System.EventHandler(this.AddSaveClassButton_Click);
            // 
            // ClassNameTextbox
            // 
            this.ClassNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassNameTextbox.Location = new System.Drawing.Point(12, 411);
            this.ClassNameTextbox.Multiline = true;
            this.ClassNameTextbox.Name = "ClassNameTextbox";
            this.ClassNameTextbox.Size = new System.Drawing.Size(245, 25);
            this.ClassNameTextbox.TabIndex = 7;
            this.ClassNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassNameTextbox.Visible = false;
            // 
            // AddClassButton
            // 
            this.AddClassButton.AnimationHoverSpeed = 0.07F;
            this.AddClassButton.AnimationSpeed = 0.03F;
            this.AddClassButton.BaseColor = System.Drawing.Color.Silver;
            this.AddClassButton.BorderColor = System.Drawing.Color.Black;
            this.AddClassButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddClassButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddClassButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddClassButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddClassButton.CheckedImage")));
            this.AddClassButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddClassButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddClassButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddClassButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddClassButton.ForeColor = System.Drawing.Color.Black;
            this.AddClassButton.Image = null;
            this.AddClassButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddClassButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddClassButton.Location = new System.Drawing.Point(12, 333);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddClassButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddClassButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddClassButton.OnHoverImage = null;
            this.AddClassButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddClassButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddClassButton.Size = new System.Drawing.Size(243, 54);
            this.AddClassButton.TabIndex = 8;
            this.AddClassButton.Text = "Добавить новый класс";
            this.AddClassButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // AddPerkButton
            // 
            this.AddPerkButton.AnimationHoverSpeed = 0.07F;
            this.AddPerkButton.AnimationSpeed = 0.03F;
            this.AddPerkButton.BaseColor = System.Drawing.Color.Silver;
            this.AddPerkButton.BorderColor = System.Drawing.Color.Black;
            this.AddPerkButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddPerkButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddPerkButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddPerkButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddPerkButton.CheckedImage")));
            this.AddPerkButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddPerkButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddPerkButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddPerkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddPerkButton.ForeColor = System.Drawing.Color.Black;
            this.AddPerkButton.Image = null;
            this.AddPerkButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddPerkButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddPerkButton.Location = new System.Drawing.Point(258, 333);
            this.AddPerkButton.Name = "AddPerkButton";
            this.AddPerkButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddPerkButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddPerkButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddPerkButton.OnHoverImage = null;
            this.AddPerkButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddPerkButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddPerkButton.Size = new System.Drawing.Size(240, 54);
            this.AddPerkButton.TabIndex = 9;
            this.AddPerkButton.Text = "Добавить перк классу";
            this.AddPerkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddPerkButton.Click += new System.EventHandler(this.AddPerkButton_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TopPanel;
            // 
            // SaveAddPerksButton
            // 
            this.SaveAddPerksButton.AnimationHoverSpeed = 0.07F;
            this.SaveAddPerksButton.AnimationSpeed = 0.03F;
            this.SaveAddPerksButton.BaseColor = System.Drawing.Color.Silver;
            this.SaveAddPerksButton.BorderColor = System.Drawing.Color.Black;
            this.SaveAddPerksButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveAddPerksButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveAddPerksButton.CheckedForeColor = System.Drawing.Color.White;
            this.SaveAddPerksButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveAddPerksButton.CheckedImage")));
            this.SaveAddPerksButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveAddPerksButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveAddPerksButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveAddPerksButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveAddPerksButton.ForeColor = System.Drawing.Color.Black;
            this.SaveAddPerksButton.Image = null;
            this.SaveAddPerksButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveAddPerksButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveAddPerksButton.Location = new System.Drawing.Point(278, 411);
            this.SaveAddPerksButton.Name = "SaveAddPerksButton";
            this.SaveAddPerksButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SaveAddPerksButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveAddPerksButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveAddPerksButton.OnHoverImage = null;
            this.SaveAddPerksButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveAddPerksButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveAddPerksButton.Size = new System.Drawing.Size(220, 54);
            this.SaveAddPerksButton.TabIndex = 10;
            this.SaveAddPerksButton.Text = "Добавить перк классу";
            this.SaveAddPerksButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveAddPerksButton.Visible = false;
            this.SaveAddPerksButton.Click += new System.EventHandler(this.SaveAddPerksButton_Click);
            // 
            // PerksComboBox
            // 
            this.PerksComboBox.FormattingEnabled = true;
            this.PerksComboBox.Items.AddRange(new object[] {
            "Ловкость (Agility)",
            "Интеллект (Intelligence)",
            "Сила (Power)",
            "Здоровье (Health)",
            "Скрытность (Stealth)"});
            this.PerksComboBox.Location = new System.Drawing.Point(35, 429);
            this.PerksComboBox.Name = "PerksComboBox";
            this.PerksComboBox.Size = new System.Drawing.Size(197, 21);
            this.PerksComboBox.TabIndex = 11;
            this.PerksComboBox.Visible = false;
            // 
            // ChoosePerksLabel
            // 
            this.ChoosePerksLabel.AutoSize = true;
            this.ChoosePerksLabel.Location = new System.Drawing.Point(32, 411);
            this.ChoosePerksLabel.Name = "ChoosePerksLabel";
            this.ChoosePerksLabel.Size = new System.Drawing.Size(202, 13);
            this.ChoosePerksLabel.TabIndex = 12;
            this.ChoosePerksLabel.Text = "Выберите пункт выпадающего сипска";
            this.ChoosePerksLabel.Visible = false;
            // 
            // ClassInformationTextbox
            // 
            this.ClassInformationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassInformationTextbox.Location = new System.Drawing.Point(12, 440);
            this.ClassInformationTextbox.Multiline = true;
            this.ClassInformationTextbox.Name = "ClassInformationTextbox";
            this.ClassInformationTextbox.Size = new System.Drawing.Size(245, 25);
            this.ClassInformationTextbox.TabIndex = 13;
            this.ClassInformationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassInformationTextbox.Visible = false;
            // 
            // ChangeClassButton
            // 
            this.ChangeClassButton.AnimationHoverSpeed = 0.07F;
            this.ChangeClassButton.AnimationSpeed = 0.03F;
            this.ChangeClassButton.BaseColor = System.Drawing.Color.Silver;
            this.ChangeClassButton.BorderColor = System.Drawing.Color.Black;
            this.ChangeClassButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ChangeClassButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ChangeClassButton.CheckedForeColor = System.Drawing.Color.White;
            this.ChangeClassButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ChangeClassButton.CheckedImage")));
            this.ChangeClassButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ChangeClassButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeClassButton.FocusedColor = System.Drawing.Color.Empty;
            this.ChangeClassButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeClassButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeClassButton.Image = null;
            this.ChangeClassButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangeClassButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeClassButton.Location = new System.Drawing.Point(278, 442);
            this.ChangeClassButton.Name = "ChangeClassButton";
            this.ChangeClassButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChangeClassButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangeClassButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangeClassButton.OnHoverImage = null;
            this.ChangeClassButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeClassButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChangeClassButton.Size = new System.Drawing.Size(220, 23);
            this.ChangeClassButton.TabIndex = 24;
            this.ChangeClassButton.Text = "Изменить выбранную запись";
            this.ChangeClassButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeClassButton.Visible = false;
            this.ChangeClassButton.Click += new System.EventHandler(this.ChangeClassButton_Click);
            // 
            // AllClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 398);
            this.Controls.Add(this.ClassInformationTextbox);
            this.Controls.Add(this.ClassNameTextbox);
            this.Controls.Add(this.ChoosePerksLabel);
            this.Controls.Add(this.PerksComboBox);
            this.Controls.Add(this.AddPerkButton);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.AddSaveClassButton);
            this.Controls.Add(this.PerksOfClassTable);
            this.Controls.Add(this.AllClassesTable);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SaveAddPerksButton);
            this.Controls.Add(this.ChangeClassButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllClassesForm";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllClassesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerksOfClassTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.DataGridView PerksOfClassTable;
        private System.Windows.Forms.DataGridView AllClassesTable;
        private Guna.UI.WinForms.GunaAdvenceButton AddSaveClassButton;
        private Guna.UI.WinForms.GunaAdvenceButton AddPerkButton;
        private Guna.UI.WinForms.GunaAdvenceButton AddClassButton;
        private System.Windows.Forms.TextBox ClassNameTextbox;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label ChoosePerksLabel;
        private System.Windows.Forms.ComboBox PerksComboBox;
        private Guna.UI.WinForms.GunaAdvenceButton SaveAddPerksButton;
        private System.Windows.Forms.TextBox ClassInformationTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton ChangeClassButton;
    }
}