namespace Kursov_Database.Forms.AdminForms
{
    partial class Talents
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
            this.TalentsLabel = new System.Windows.Forms.Label();
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.AllTalentsTable = new System.Windows.Forms.DataGridView();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllTalentsTable)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TalentsLabel
            // 
            this.TalentsLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TalentsLabel.Location = new System.Drawing.Point(388, 41);
            this.TalentsLabel.Name = "TalentsLabel";
            this.TalentsLabel.Size = new System.Drawing.Size(351, 155);
            this.TalentsLabel.TabIndex = 7;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.TargetControl = this;
            // 
            // AllTalentsTable
            // 
            this.AllTalentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllTalentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllTalentsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllTalentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllTalentsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.AllTalentsTable.Location = new System.Drawing.Point(12, 41);
            this.AllTalentsTable.Name = "AllTalentsTable";
            this.AllTalentsTable.ReadOnly = true;
            this.AllTalentsTable.Size = new System.Drawing.Size(370, 155);
            this.AllTalentsTable.TabIndex = 6;
            this.AllTalentsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
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
            this.CollapseButton.Location = new System.Drawing.Point(699, 10);
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
            this.CloseButton.Location = new System.Drawing.Point(723, 10);
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
            this.TopPanel.Size = new System.Drawing.Size(751, 35);
            this.TopPanel.TabIndex = 8;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // Talents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 206);
            this.Controls.Add(this.TalentsLabel);
            this.Controls.Add(this.AllTalentsTable);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Talents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Talents";
            ((System.ComponentModel.ISupportInitialize)(this.AllTalentsTable)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TalentsLabel;
        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.DataGridView AllTalentsTable;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
    }
}