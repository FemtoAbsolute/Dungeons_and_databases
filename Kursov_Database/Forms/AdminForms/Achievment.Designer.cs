namespace Kursov_Database.Forms.AdminForms
{
    partial class Achievment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Achievment));
            this.AchievmentLabel = new System.Windows.Forms.Label();
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.AllAchievmentsTable = new System.Windows.Forms.DataGridView();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.AchievmentNameTextbox = new System.Windows.Forms.TextBox();
            this.AchievmentInformationTextbox = new System.Windows.Forms.TextBox();
            this.AddAchievmentButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AchievmentRewardTextbox = new System.Windows.Forms.TextBox();
            this.RewardLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.AllAchievmentsTable)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AchievmentLabel
            // 
            this.AchievmentLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AchievmentLabel.Location = new System.Drawing.Point(225, 45);
            this.AchievmentLabel.Name = "AchievmentLabel";
            this.AchievmentLabel.Size = new System.Drawing.Size(205, 93);
            this.AchievmentLabel.TabIndex = 16;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.TargetControl = this;
            // 
            // AllAchievmentsTable
            // 
            this.AllAchievmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllAchievmentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllAchievmentsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllAchievmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllAchievmentsTable.Location = new System.Drawing.Point(12, 45);
            this.AllAchievmentsTable.Name = "AllAchievmentsTable";
            this.AllAchievmentsTable.ReadOnly = true;
            this.AllAchievmentsTable.Size = new System.Drawing.Size(207, 141);
            this.AllAchievmentsTable.TabIndex = 15;
            this.AllAchievmentsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
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
            this.CollapseButton.Location = new System.Drawing.Point(388, 12);
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
            this.CloseButton.Location = new System.Drawing.Point(412, 12);
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
            this.TopPanel.Size = new System.Drawing.Size(442, 35);
            this.TopPanel.TabIndex = 17;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // AchievmentNameTextbox
            // 
            this.AchievmentNameTextbox.Location = new System.Drawing.Point(12, 192);
            this.AchievmentNameTextbox.Multiline = true;
            this.AchievmentNameTextbox.Name = "AchievmentNameTextbox";
            this.AchievmentNameTextbox.Size = new System.Drawing.Size(207, 22);
            this.AchievmentNameTextbox.TabIndex = 20;
            // 
            // AchievmentInformationTextbox
            // 
            this.AchievmentInformationTextbox.Location = new System.Drawing.Point(12, 220);
            this.AchievmentInformationTextbox.Multiline = true;
            this.AchievmentInformationTextbox.Name = "AchievmentInformationTextbox";
            this.AchievmentInformationTextbox.Size = new System.Drawing.Size(418, 40);
            this.AchievmentInformationTextbox.TabIndex = 18;
            // 
            // AddAchievmentButton
            // 
            this.AddAchievmentButton.AnimationHoverSpeed = 0.07F;
            this.AddAchievmentButton.AnimationSpeed = 0.03F;
            this.AddAchievmentButton.BaseColor = System.Drawing.Color.Silver;
            this.AddAchievmentButton.BorderColor = System.Drawing.Color.Black;
            this.AddAchievmentButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddAchievmentButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddAchievmentButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddAchievmentButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddAchievmentButton.CheckedImage")));
            this.AddAchievmentButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddAchievmentButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddAchievmentButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddAchievmentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddAchievmentButton.ForeColor = System.Drawing.Color.Black;
            this.AddAchievmentButton.Image = null;
            this.AddAchievmentButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddAchievmentButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddAchievmentButton.Location = new System.Drawing.Point(12, 266);
            this.AddAchievmentButton.Name = "AddAchievmentButton";
            this.AddAchievmentButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddAchievmentButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddAchievmentButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddAchievmentButton.OnHoverImage = null;
            this.AddAchievmentButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddAchievmentButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddAchievmentButton.Size = new System.Drawing.Size(415, 31);
            this.AddAchievmentButton.TabIndex = 19;
            this.AddAchievmentButton.Text = "Добавить новое достижение";
            this.AddAchievmentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddAchievmentButton.Click += new System.EventHandler(this.AddAchievmentButton_Click);
            // 
            // AchievmentRewardTextbox
            // 
            this.AchievmentRewardTextbox.Location = new System.Drawing.Point(223, 192);
            this.AchievmentRewardTextbox.Multiline = true;
            this.AchievmentRewardTextbox.Name = "AchievmentRewardTextbox";
            this.AchievmentRewardTextbox.Size = new System.Drawing.Size(207, 22);
            this.AchievmentRewardTextbox.TabIndex = 21;
            // 
            // RewardLabel
            // 
            this.RewardLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RewardLabel.Location = new System.Drawing.Point(225, 138);
            this.RewardLabel.Name = "RewardLabel";
            this.RewardLabel.Size = new System.Drawing.Size(205, 48);
            this.RewardLabel.TabIndex = 22;
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
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeButton.Image = null;
            this.ChangeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.Location = new System.Drawing.Point(12, 303);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChangeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangeButton.OnHoverImage = null;
            this.ChangeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChangeButton.Size = new System.Drawing.Size(415, 31);
            this.ChangeButton.TabIndex = 23;
            this.ChangeButton.Text = "Изменить выбранную запись";
            this.ChangeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Achievment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 341);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.RewardLabel);
            this.Controls.Add(this.AchievmentRewardTextbox);
            this.Controls.Add(this.AchievmentLabel);
            this.Controls.Add(this.AllAchievmentsTable);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.AchievmentNameTextbox);
            this.Controls.Add(this.AddAchievmentButton);
            this.Controls.Add(this.AchievmentInformationTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Achievment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achievment";
            ((System.ComponentModel.ISupportInitialize)(this.AllAchievmentsTable)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AchievmentLabel;
        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.DataGridView AllAchievmentsTable;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private System.Windows.Forms.TextBox AchievmentNameTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton AddAchievmentButton;
        private System.Windows.Forms.TextBox AchievmentInformationTextbox;
        private System.Windows.Forms.TextBox AchievmentRewardTextbox;
        private System.Windows.Forms.Label RewardLabel;
        private Guna.UI.WinForms.GunaAdvenceButton ChangeButton;
    }
}