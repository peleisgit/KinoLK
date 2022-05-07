using KinoLK.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoLK.Employee
{
    public partial class Account : Form
    {
        public int id_user;
        ConnectionDB connection = new ConnectionDB();
        User user;

        public Account(int id)
        {
            InitializeComponent();
            id_user = id;

            //
            user = connection.UserById(id);
            string name = user.Name;
            string lastname = user.Lastname;
            double rate = user.Rate;
            TimeSpan totalWorktime = connection.GetRegisterWorkingHours(id_user);
            string[] workTime = totalWorktime.ToString().Split(':');
            int h = 0, m = 0, s = 0;
            for (int i = 0; i < workTime.Length; i++)
            {
                if (i == 0)
                {
                    h = h + Int32.Parse(workTime[i]);
                }
                if (i == 1)
                {
                    m = m + Int32.Parse(workTime[i]);
                }
                if (i == 2)
                {
                    s = s + Int32.Parse(workTime[i]);
                }
            }



            double salary = (rate * h) + (rate / 60 * m) + (rate / 60 / 60 * s);

            LabelName.Text = name;
            LabelLastname.Text = lastname;
            LabelRate.Text = rate.ToString() + "zł";
            LabelTotalWorktime.Text = totalWorktime.ToString();
            LabelSalary.Text = Math.Round(salary, 2).ToString() + "zł";
        }

        internal User User { get => user; set => user = value; }

        private void Account_Load(object sender, EventArgs e)
        {
            connection.GetDataGridView("SELECT czas AS 'Czas zalogowania', data_dodania_godzin_pracy AS 'Data' FROM mydb.godziny_pracy WHERE Uzytkownik_idUser = '" + id_user + "';", DGVlogs);
        }

        private void DGVlogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
