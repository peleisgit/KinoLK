using KinoLK.Admin;
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
    public partial class Admin_main_panel : Form
    {
        private Form form;
        public int id_user;

        public Admin_main_panel(int id)
        {
            InitializeComponent();
            id_user = id;
        }

        #region BTN LOGOWANIE        
        private void button4_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            ActiveForm.Hide();
            logowanie.Show();
        }
        #endregion
        #region BTN EMPLOYEE  
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            form = new Employees(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();    
        }
        #endregion
        #region BTN MOVIES  
        private void MoviesBtn_Click(object sender, EventArgs e)
        {
            form = new Movies(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion
        #region BTN BILANS  
        private void BilansBtn_Click(object sender, EventArgs e)
        {
            form = new Bilans(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion
        #region BTN COST  
        private void CostBtn_Click(object sender, EventArgs e)
        {
            form = new Report_Cost(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion
        #region BTN SALE  
        private void SaleBtn_Click(object sender, EventArgs e)
        {

            form = new Report_Sales(id_user);
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion

        private void SeanseBtn_Click(object sender, EventArgs e)
        {
            form = new Seans();
            form.TopLevel = false;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}