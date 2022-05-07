using KinoLK.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace KinoLK.Employee
{
    public partial class Employee_main_panel : Form
    {
        ConnectionDB connection = new ConnectionDB();
        private Form form;
        private Form formDashboard;
        private DateTime currectDate = DateTime.Now;
        System.Timers.Timer workTimer;
        int hour, minute, second;
        public int id_user;
        Dashboard dashboard;
        User user;  
        
        public Employee_main_panel(int id)
        {
            InitializeComponent();
            id_user = id;            
            user = connection.UserById(id);
        }

        private void Employee_main_panel_Load(object sender, EventArgs e)
        {
            string totalWorktime = connection.GetRegisterWorkingHours(id_user).ToString();
            connection.UpdateRegisterWorkingHours(id_user, totalWorktime);
            workTimer = new System.Timers.Timer();
            workTimer.Interval = 1000; // 1s
            workTimer.Elapsed += OnTimeEvents;
            workTimer.Start();
        }


       
        private void OnTimeEvents(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                second += 1;
                if (second == 60)
                {
                    second = 0;
                    minute += 1;
                }
                if (minute == 60)
                {
                    minute = 0;
                    hour += 1;
                }
                TimerText.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            }));
        }       

        private void Employee_main_panel_FormClosing(object sender, FormClosingEventArgs e)
        {           
            workTimer.Stop();
            Application.DoEvents();
        }

        #region BTN PANEL
        private void BtnPanel_Click(object sender, EventArgs e)
        {
            formDashboard = new Dashboard(id_user);
            dashboard = new Dashboard(id_user);
            formDashboard.TopLevel = false;
            panel2.Controls.Add(formDashboard);
            panel2.Tag = formDashboard;
            formDashboard.BringToFront();
            formDashboard.Show();
        }
        #endregion 
        #region BTN ACCOUNT
        private void BtnAccount_Click(object sender, EventArgs e)
        {
            form = new Account(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion
        #region BTN LOGOUT
        private void LogoutBtn_Click(object sender, EventArgs e)
        {       

            if(dashboard != null)
            {
                connection.SendIncome(currectDate.ToString("yyyy-MM-dd"), dashboard.NumberTransaction, dashboard.Income, dashboard.TicketsSold, dashboard.NumberPopcorns, dashboard.NumberDrinks);
            }           
            connection.RegisterWorkingHours(id_user, string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0')), currectDate.ToString("yyyy-MM-dd"));

           
            double dailyWage = (user.Rate * hour) + (user.Rate / 60 * minute) + (user.Rate / 60 / 60 * second);

            connection.SendCost(currectDate.ToString("yyyy-MM-dd"), dailyWage);
            Logowanie logowanie = new Logowanie();
            ActiveForm.Hide();
            logowanie.Show();
        }
        #endregion
    }
}
