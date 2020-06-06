namespace Kursov_Database.Forms.AdminForms
{
    partial class Profession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profession));
            this.ProfessionLabel = new System.Windows.Forms.Label();
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.AllProfessionsTable = new System.Windows.Forms.DataGridView();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ProfessionInformationTextbox = new System.Windows.Forms.TextBox();
            this.AddProfessionButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProfessionNameTextbox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.AllProfessionsTable)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfessionLabel
            // 
            this.ProfessionLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionLabel.Location = new System.Drawing.Point(298, 41);
            this.ProfessionLabel.Name = "ProfessionLabel";
            this.ProfessionLabel.Size = new System.Drawing.Size(270, 214);
            this.ProfessionLabel.TabIndex = 10;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.TargetControl = this;
            // 
            // AllProfessionsTable
            // 
            this.AllProfessionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllProfessionsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllProfessionsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllProfessionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllProfessionsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.AllProfessionsTable.Location = new System.Drawing.Point(12, 41);
            this.AllProfessionsTable.Name = "AllProfessionsTable";
            this.AllProfessionsTable.ReadOnly = true;
            this.AllProfessionsTable.Size = new System.Drawing.Size(280, 214);
            this.AllProfessionsTable.TabIndex = 9;
            this.AllProfessionsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
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
            this.CollapseButton.Location = new System.Drawing.Point(526, 12);
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
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click_1);
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
            this.CloseButton.Location = new System.Drawing.Point(550, 12);
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
            this.TopPanel.Size = new System.Drawing.Size(581, 35);
            this.TopPanel.TabIndex = 11;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // ProfessionInformationTextbox
            // 
            this.ProfessionInformationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionInformationTextbox.Location = new System.Drawing.Point(12, 303);
            this.ProfessionInformationTextbox.Multiline = true;
            this.ProfessionInformationTextbox.Name = "ProfessionInformationTextbox";
            this.ProfessionInformationTextbox.Size = new System.Drawing.Size(556, 60);
            this.ProfessionInformationTextbox.TabIndex = 12;
            // 
            // AddProfessionButton
            // 
            this.AddProfessionButton.AnimationHoverSpeed = 0.07F;
            this.AddProfessionButton.AnimationSpeed = 0.03F;
            this.AddProfessionButton.BaseColor = System.Drawing.Color.Silver;
            this.AddProfessionButton.BorderColor = System.Drawing.Color.Black;
            this.AddProfessionButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddProfessionButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddProfessionButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddProfessionButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddProfessionButton.CheckedImage")));
            this.AddProfessionButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddProfessionButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddProfessionButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddProfessionButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProfessionButton.ForeColor = System.Drawing.Color.Black;
            this.AddProfessionButton.Image = null;
            this.AddProfessionButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddProfessionButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddProfessionButton.Location = new System.Drawing.Point(12, 369);
            this.AddProfessionButton.Name = "AddProfessionButton";
            this.AddProfessionButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddProfessionButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddProfessionButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddProfessionButton.OnHoverImage = null;
            this.AddProfessionButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddProfessionButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddProfessionButton.Size = new System.Drawing.Size(556, 43);
            this.AddProfessionButton.TabIndex = 13;
            this.AddProfessionButton.Text = "Добавить новую профессию";
            this.AddProfessionButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddProfessionButton.Click += new System.EventHandler(this.AddProfessionButton_Click);
            // 
            // ProfessionNameTextbox
            // 
            this.ProfessionNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionNameTextbox.Location = new System.Drawing.Point(12, 261);
            this.ProfessionNameTextbox.Multiline = true;
            this.ProfessionNameTextbox.Name = "ProfessionNameTextbox";
            this.ProfessionNameTextbox.Size = new System.Drawing.Size(557, 36);
            this.ProfessionNameTextbox.TabIndex = 14;
            // 
            // ChangeButton
            // 
            this.ChangeButton.AnimationHoverSpeed = 0.07F;
            this.ChangeButton.AnimationSpeed = 0.03F;
            this.ChangeButton.BaseColor = System.Drawing.Color.Silver;
            this.ChangeButton.BorderColor = System.Drawing.Color.Black;
            this.ChangeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ChangeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ChangeButton.CheckedForeColor = System.Drawing.Color.White;
            this.ChangeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ChangeButton.CheckedImage")));
            this.ChangeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ChangeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeButton.FocusedColor = System.Drawing.Color.Empty;
            this.ChangeButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeButton.Image = null;
            this.ChangeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.Location = new System.Drawing.Point(12, 418);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChangeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangeButton.OnHoverImage = null;
            this.ChangeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChangeButton.Size = new System.Drawing.Size(556, 40);
            this.ChangeButton.TabIndex = 24;
            this.ChangeButton.Text = "Изменить выбранную запись";
            this.ChangeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Profession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 470);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ProfessionNameTextbox);
            this.Controls.Add(this.AddProfessionButton);
            this.Controls.Add(this.ProfessionInformationTextbox);
            this.Controls.Add(this.ProfessionLabel);
            this.Controls.Add(this.AllProfessionsTable);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profession";
            ((System.ComponentModel.ISupportInitialize)(this.AllProfessionsTable)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfessionLabel;
        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.DataGridView AllProfessionsTable;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private System.Windows.Forms.TextBox ProfessionInformationTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton AddProfessionButton;
        private System.Windows.Forms.TextBox ProfessionNameTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton ChangeButton;
    }
}