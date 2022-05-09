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
    public partial class Bilans : Form
    {
        int id_admina;
        ConnectionDB connection = new ConnectionDB();
        public Bilans(int id_admina)
        {
            this.id_admina = id_admina;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            connection.GetDataGridView("SELECT data AS 'Data', przychody AS 'Przychody', koszty AS 'Koszty' FROM mydb.bilans_rachunku where data=Convert('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',date);", DGVbilans);
        }

        private void Bilans_Load(object sender, EventArgs e)
        {
            connection.GetDataGridView("SELECT data AS 'Data', przychody AS 'Przychody', koszty AS 'Koszty' FROM mydb.bilans_rachunku;", DGVbilans);
        }

        private void DGVbilans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
