
namespace KinoLK.Administrator
{
    partial class Employees
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
            this.DGVemployees = new System.Windows.Forms.DataGridView();
            this.RemoveEmployeeBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.NumericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.TextBoxPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVemployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVemployees
            // 
            this.DGVemployees.AllowUserToAddRows = false;
            this.DGVemployees.AllowUserToDeleteRows = false;
            this.DGVemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVemployees.Location = new System.Drawing.Point(0, 12);
            this.DGVemployees.Name = "DGVemployees";
            this.DGVemployees.Size = new System.Drawing.Size(834, 238);
            this.DGVemployees.TabIndex = 1;
            this.DGVemployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVemployees_CellClick);
            this.DGVemployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVemployees_CellContentClick);
            this.DGVemployees.SelectionChanged += new System.EventHandler(this.DGVemployees_SelectionChanged);
            // 
            // RemoveEmployeeBtn
            // 
            this.RemoveEmployeeBtn.Location = new System.Drawing.Point(622, 417);
            this.RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            this.RemoveEmployeeBtn.Size = new System.Drawing.Size(162, 23);
            this.RemoveEmployeeBtn.TabIndex = 13;
            this.RemoveEmployeeBtn.Text = "Usuń";
            this.RemoveEmployeeBtn.UseVisualStyleBackColor = true;
            this.RemoveEmployeeBtn.Click += new System.EventHandler(this.RemoveEmployeeBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Location = new System.Drawing.Point(622, 387);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(162, 23);
            this.EditEmployeeBtn.TabIndex = 12;
            this.EditEmployeeBtn.Text = "Edytuj";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Location = new System.Drawing.Point(622, 357);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(162, 23);
            this.AddEmployeeBtn.TabIndex = 11;
            this.AddEmployeeBtn.Text = "Dodaj pracownika";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stawka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hasło";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Login";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(132, 290);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 20;
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Location = new System.Drawing.Point(132, 319);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastname.TabIndex = 22;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(129, 410);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLogin.TabIndex = 23;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(129, 440);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 24;
            // 
            // NumericUpDownRate
            // 
            this.NumericUpDownRate.Location = new System.Drawing.Point(129, 376);
            this.NumericUpDownRate.Name = "NumericUpDownRate";
            this.NumericUpDownRate.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownRate.TabIndex = 25;
            // 
            // TextBoxPosition
            // 
            this.TextBoxPosition.Location = new System.Drawing.Point(132, 345);
            this.TextBoxPosition.Name = "TextBoxPosition";
            this.TextBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPosition.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Stanowisko";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.TextBoxPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericUpDownRate);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveEmployeeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.DGVemployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVemployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVemployees;
        private System.Windows.Forms.Button RemoveEmployeeBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxLastname;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.NumericUpDown NumericUpDownRate;
        private System.Windows.Forms.TextBox TextBoxPosition;
        private System.Windows.Forms.Label label4;
    }
}