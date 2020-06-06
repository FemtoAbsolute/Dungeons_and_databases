namespace Kursov_Database.Forms.AdminForms
{
    partial class ProceedQuerry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProceedQuerry));
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.QuerryDatagrid = new System.Windows.Forms.DataGridView();
            this.QuerryTextbox = new System.Windows.Forms.TextBox();
            this.QuerryButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuerryDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TopPanel.Controls.Add(this.CollapseButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(515, 35);
            this.TopPanel.TabIndex = 4;
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
            // QuerryDatagrid
            // 
            this.QuerryDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuerryDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.QuerryDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QuerryDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuerryDatagrid.Location = new System.Drawing.Point(12, 82);
            this.QuerryDatagrid.Name = "QuerryDatagrid";
            this.QuerryDatagrid.ReadOnly = true;
            this.QuerryDatagrid.Size = new System.Drawing.Size(491, 356);
            this.QuerryDatagrid.TabIndex = 5;
            // 
            // QuerryTextbox
            // 
            this.QuerryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuerryTextbox.Location = new System.Drawing.Point(12, 41);
            this.QuerryTextbox.Multiline = true;
            this.QuerryTextbox.Name = "QuerryTextbox";
            this.QuerryTextbox.Size = new System.Drawing.Size(385, 35);
            this.QuerryTextbox.TabIndex = 6;
            // 
            // QuerryButton
            // 
            this.QuerryButton.AnimationHoverSpeed = 0.07F;
            this.QuerryButton.AnimationSpeed = 0.03F;
            this.QuerryButton.BaseColor = System.Drawing.Color.Silver;
            this.QuerryButton.BorderColor = System.Drawing.Color.Black;
            this.QuerryButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.QuerryButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.QuerryButton.CheckedForeColor = System.Drawing.Color.White;
            this.QuerryButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("QuerryButton.CheckedImage")));
            this.QuerryButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.QuerryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.QuerryButton.FocusedColor = System.Drawing.Color.Empty;
            this.QuerryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuerryButton.ForeColor = System.Drawing.Color.Black;
            this.QuerryButton.Image = null;
            this.QuerryButton.ImageSize = new System.Drawing.Size(20, 20);
            this.QuerryButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.QuerryButton.Location = new System.Drawing.Point(403, 41);
            this.QuerryButton.Name = "QuerryButton";
            this.QuerryButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.QuerryButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.QuerryButton.OnHoverForeColor = System.Drawing.Color.White;
            this.QuerryButton.OnHoverImage = null;
            this.QuerryButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.QuerryButton.OnPressedColor = System.Drawing.Color.Black;
            this.QuerryButton.Size = new System.Drawing.Size(100, 35);
            this.QuerryButton.TabIndex = 10;
            this.QuerryButton.Text = "Выполнить";
            this.QuerryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuerryButton.Click += new System.EventHandler(this.QuerryButton_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TopPanel;
            // 
            // ProceedQuerry
            // 
            this.AcceptButton = this.QuerryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.QuerryButton);
            this.Controls.Add(this.QuerryTextbox);
            this.Controls.Add(this.QuerryDatagrid);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProceedQuerry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProceedQuerry";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuerryDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.TextBox QuerryTextbox;
        private System.Windows.Forms.DataGridView QuerryDatagrid;
        private Guna.UI.WinForms.GunaAdvenceButton QuerryButton;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}