namespace Kursov_Database.Forms
{
    partial class QuerryForm
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
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ShowPerksButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AllClassesButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(508, 35);
            this.TopPanel.TabIndex = 0;
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
            // ShowPerksButton
            // 
            this.ShowPerksButton.AnimationHoverSpeed = 0.07F;
            this.ShowPerksButton.AnimationSpeed = 0.03F;
            this.ShowPerksButton.BaseColor = System.Drawing.Color.DarkGray;
            this.ShowPerksButton.BorderColor = System.Drawing.Color.Black;
            this.ShowPerksButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ShowPerksButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ShowPerksButton.CheckedForeColor = System.Drawing.Color.White;
            this.ShowPerksButton.CheckedImage = null;
            this.ShowPerksButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ShowPerksButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ShowPerksButton.FocusedColor = System.Drawing.Color.Empty;
            this.ShowPerksButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowPerksButton.ForeColor = System.Drawing.Color.White;
            this.ShowPerksButton.Image = null;
            this.ShowPerksButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ShowPerksButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ShowPerksButton.Location = new System.Drawing.Point(12, 41);
            this.ShowPerksButton.Name = "ShowPerksButton";
            this.ShowPerksButton.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.ShowPerksButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ShowPerksButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ShowPerksButton.OnHoverImage = null;
            this.ShowPerksButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ShowPerksButton.OnPressedColor = System.Drawing.Color.Black;
            this.ShowPerksButton.Size = new System.Drawing.Size(236, 42);
            this.ShowPerksButton.TabIndex = 1;
            this.ShowPerksButton.Text = "Показать список перков";
            this.ShowPerksButton.Click += new System.EventHandler(this.ShowPerksButton_Click);
            // 
            // AllClassesButton
            // 
            this.AllClassesButton.AnimationHoverSpeed = 0.07F;
            this.AllClassesButton.AnimationSpeed = 0.03F;
            this.AllClassesButton.BaseColor = System.Drawing.Color.DarkGray;
            this.AllClassesButton.BorderColor = System.Drawing.Color.Black;
            this.AllClassesButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AllClassesButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AllClassesButton.CheckedForeColor = System.Drawing.Color.White;
            this.AllClassesButton.CheckedImage = null;
            this.AllClassesButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AllClassesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AllClassesButton.FocusedColor = System.Drawing.Color.Empty;
            this.AllClassesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllClassesButton.ForeColor = System.Drawing.Color.White;
            this.AllClassesButton.Image = null;
            this.AllClassesButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AllClassesButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AllClassesButton.Location = new System.Drawing.Point(254, 41);
            this.AllClassesButton.Name = "AllClassesButton";
            this.AllClassesButton.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.AllClassesButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AllClassesButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AllClassesButton.OnHoverImage = null;
            this.AllClassesButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AllClassesButton.OnPressedColor = System.Drawing.Color.Black;
            this.AllClassesButton.Size = new System.Drawing.Size(242, 42);
            this.AllClassesButton.TabIndex = 2;
            this.AllClassesButton.Text = "Добавить новый класс";
            this.AllClassesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AllClassesButton.Click += new System.EventHandler(this.AllClassesButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 274);
            this.Controls.Add(this.AllClassesButton);
            this.Controls.Add(this.ShowPerksButton);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private Guna.UI.WinForms.GunaAdvenceButton ShowPerksButton;
        private Guna.UI.WinForms.GunaAdvenceButton AllClassesButton;
    }
}