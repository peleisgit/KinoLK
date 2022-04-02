
namespace KinoLK.Administrator
{
    partial class Admin_main_panel
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
            this.MoviesBtn = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.SaleBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CostBtn = new System.Windows.Forms.Button();
            this.BilansBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeanseBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesBtn
            // 
            this.MoviesBtn.Location = new System.Drawing.Point(13, 17);
            this.MoviesBtn.Name = "MoviesBtn";
            this.MoviesBtn.Size = new System.Drawing.Size(250, 25);
            this.MoviesBtn.TabIndex = 0;
            this.MoviesBtn.Text = "Filmy";
            this.MoviesBtn.UseVisualStyleBackColor = true;
            this.MoviesBtn.Click += new System.EventHandler(this.MoviesBtn_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.Location = new System.Drawing.Point(13, 46);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(250, 25);
            this.EmployeeBtn.TabIndex = 1;
            this.EmployeeBtn.Text = "Pracownicy";
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // SaleBtn
            // 
            this.SaleBtn.Location = new System.Drawing.Point(13, 77);
            this.SaleBtn.Name = "SaleBtn";
            this.SaleBtn.Size = new System.Drawing.Size(250, 25);
            this.SaleBtn.TabIndex = 2;
            this.SaleBtn.Text = "Raport sprzedaży";
            this.SaleBtn.UseVisualStyleBackColor = true;
            this.SaleBtn.Click += new System.EventHandler(this.SaleBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(13, 486);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(250, 25);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Wyloguj";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // CostBtn
            // 
            this.CostBtn.Location = new System.Drawing.Point(13, 106);
            this.CostBtn.Name = "CostBtn";
            this.CostBtn.Size = new System.Drawing.Size(250, 25);
            this.CostBtn.TabIndex = 4;
            this.CostBtn.Text = "Raport kosztów";
            this.CostBtn.UseVisualStyleBackColor = true;
            this.CostBtn.Click += new System.EventHandler(this.CostBtn_Click);
            // 
            // BilansBtn
            // 
            this.BilansBtn.Location = new System.Drawing.Point(13, 135);
            this.BilansBtn.Name = "BilansBtn";
            this.BilansBtn.Size = new System.Drawing.Size(250, 25);
            this.BilansBtn.TabIndex = 5;
            this.BilansBtn.Text = "Bilans";
            this.BilansBtn.UseVisualStyleBackColor = true;
            this.BilansBtn.Click += new System.EventHandler(this.BilansBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeanseBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MoviesBtn);
            this.panel1.Controls.Add(this.BilansBtn);
            this.panel1.Controls.Add(this.EmployeeBtn);
            this.panel1.Controls.Add(this.CostBtn);
            this.panel1.Controls.Add(this.SaleBtn);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 537);
            this.panel1.TabIndex = 6;
            // 
            // SeanseBtn
            // 
            this.SeanseBtn.Location = new System.Drawing.Point(13, 219);
            this.SeanseBtn.Name = "SeanseBtn";
            this.SeanseBtn.Size = new System.Drawing.Size(250, 23);
            this.SeanseBtn.TabIndex = 7;
            this.SeanseBtn.Text = "Seanse";
            this.SeanseBtn.UseVisualStyleBackColor = true;
            this.SeanseBtn.Click += new System.EventHandler(this.SeanseBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(283, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 511);
            this.panel2.TabIndex = 6;
            // 
            // Admin_main_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_main_panel";
            this.Text = "Administrator_main_panel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoviesBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button SaleBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button CostBtn;
        private System.Windows.Forms.Button BilansBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SeanseBtn;
    }
}