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
    public partial class Report_Cost : Form
    {
        int id_admina;
        ConnectionDB connection = new ConnectionDB();
        public Report_Cost(int id_admina)
        {
            this.id_admina = id_admina;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            connection.GetDataGridView("SELECT data AS 'Data', koszty AS 'Koszty' FROM mydb.bilans_rachunku where data=Convert('"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"',date);", DGVcost);
        }

        private void Report_Cost_Load(object sender, EventArgs e)
        {
            connection.GetDataGridView("SELECT data AS 'Data', koszty AS 'Koszty' FROM mydb.bilans_rachunku;", DGVcost);
        }

        private void DGVcost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
