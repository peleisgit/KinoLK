using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoLK.Administrator
{
    public partial class Employees : Form
    {
        int id_admina;
        int selected_id;
        ConnectionDB connection = new ConnectionDB();

        private string login = ""; 
        private string password = "";
        private string lastname = ""; 
        private string name = "";
        private string position = "";
        private double rate = 0;

        public Employees(int id_admina)
        {
            this.id_admina = id_admina;          
          
            InitializeComponent();

        }

        private void GetDGVemployees()
        {
            connection.GetDataGridView("SELECT idUser as 'ID', login as 'Login', haslo as 'Hasło',nazwisko as 'Nazwisko',imie as 'Imię',stanowisko as 'Stanowisko',stawka as 'Stawka brutto',laczny_czas_pracy as 'Łączny czas pracy'FROM mydb.uzytkownik;", DGVemployees);
        }


        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            login = TextBoxLogin.Text;
            password = TextBoxPassword.Text;
            lastname = TextBoxLastname.Text;
            name = TextBoxName.Text;
            position = TextBoxPosition.Text;
            rate = (double)NumericUpDownRate.Value;

            if (login != "" || password != "" || lastname != "" || name != "" || position != "" || rate == 0)
            {
                connection.AddNewEmployee(login, password, lastname, name, position, rate);
                GetDGVemployees();
            }
            else 
            {                
                    MessageBox.Show("Wypełnij dane");
            }
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {          
            connection.RemoveEmployee(selected_id);
            GetDGVemployees();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            GetDGVemployees();
        }

       

        private void DGVemployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e != null)
            {
                selected_id = (int)DGVemployees.Rows[e.RowIndex].Cells[0].Value;
                TextBoxLogin.Text = DGVemployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBoxPassword.Text = DGVemployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                TextBoxLastname.Text = DGVemployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                TextBoxName.Text = DGVemployees.Rows[e.RowIndex].Cells[4].Value.ToString();
                TextBoxPosition.Text = DGVemployees.Rows[e.RowIndex].Cells[5].Value.ToString();
                NumericUpDownRate.Value = (decimal)DGVemployees.Rows[e.RowIndex].Cells[6].Value;              
            }
           
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            connection.EditEmployee(selected_id, TextBoxLogin.Text, TextBoxPassword.Text, TextBoxLastname.Text, TextBoxName.Text, TextBoxPosition.Text, NumericUpDownRate.Value);
            GetDGVemployees();
        }

        private void DGVemployees_SelectionChanged(object sender, EventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid; 
        }

        private void DGVemployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
