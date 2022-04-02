
namespace KinoLK.Employee
{
    partial class Employee_main_panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeWorkLabel = new System.Windows.Forms.Label();
            this.TimerText = new System.Windows.Forms.TextBox();
            this.BtnPanel = new System.Windows.Forms.Button();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeWorkLabel);
            this.panel1.Controls.Add(this.TimerText);
            this.panel1.Controls.Add(this.BtnPanel);
            this.panel1.Controls.Add(this.BtnAccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 537);
            this.panel1.TabIndex = 7;
            // 
            // timeWorkLabel
            // 
            this.timeWorkLabel.AutoSize = true;
            this.timeWorkLabel.Location = new System.Drawing.Point(10, 408);
            this.timeWorkLabel.Name = "timeWorkLabel";
            this.timeWorkLabel.Size = new System.Drawing.Size(134, 13);
            this.timeWorkLabel.TabIndex = 22;
            this.timeWorkLabel.Text = "Czas dzisiejszej sesji pracy:";
            // 
            // TimerText
            // 
            this.TimerText.Location = new System.Drawing.Point(162, 401);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(100, 20);
            this.TimerText.TabIndex = 23;
            this.TimerText.Text = "00:00:00";
            this.TimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPanel
            // 
            this.BtnPanel.Location = new System.Drawing.Point(13, 31);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(250, 25);
            this.BtnPanel.TabIndex = 21;
            this.BtnPanel.Text = "Panel";
            this.BtnPanel.UseVisualStyleBackColor = true;
            this.BtnPanel.Click += new System.EventHandler(this.BtnPanel_Click);
            // 
            // BtnAccount
            // 
            this.BtnAccount.Location = new System.Drawing.Point(13, 60);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(249, 23);
            this.BtnAccount.TabIndex = 20;
            this.BtnAccount.Text = "Moje konto";
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(283, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 511);
            this.panel2.TabIndex = 6;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(13, 486);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(250, 25);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Wyloguj";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Employee_main_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_main_panel";
            this.Text = "Employee_main_panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_main_panel_FormClosing);
            this.Load += new System.EventHandler(this.Employee_main_panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BtnPanel;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Label timeWorkLabel;
        private System.Windows.Forms.TextBox TimerText;
    }
}