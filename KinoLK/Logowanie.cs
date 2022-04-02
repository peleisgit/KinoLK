using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KinoLK
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void zalogujBtn_Click(object sender, EventArgs e)
        {
            ConnectionDB connection = new ConnectionDB();
            string loginUser = loginInput.Text;
            string passwordUser = passwordInput.Text;
            int id = connection.CheckLogin(loginUser, passwordUser);


            if (id == 0)
            {
                MessageBox.Show("Błąd danych");

            }
            else
            {
                int type = connection.CheckTypeUser(id);
                if (type == 0)
                {
                    Employee.Employee_main_panel employee = new Employee.Employee_main_panel(id);
                    ActiveForm.Hide();
                    employee.Show();
                }
                else
                {
                    Administrator.Admin_main_panel admin = new Administrator.Admin_main_panel(id);
                    ActiveForm.Hide();
                    admin.Show();
                }
            }


        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)  passwordInput.PasswordChar = '\0'; 
            else  passwordInput.PasswordChar = '*'; 
        }
    }
}