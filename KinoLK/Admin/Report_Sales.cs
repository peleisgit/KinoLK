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
    public partial class Report_Sales : Form
    {
        int id_admina;
        ConnectionDB connection = new ConnectionDB();
        public Report_Sales(int id_admina)
        {
            this.id_admina = id_admina;
            InitializeComponent();
        }       

        private void Report_Sales_Load(object sender, EventArgs e)
        {
            connection.GetDataGridView("SELECT data AS 'Data', przychody AS 'Przychody', ilosc_sprzedanych_biletow AS 'Liczba sprzedanych biletów', ilosc_transakcji AS 'Liczba transakcji', liczba_popcornu AS 'Liczba sprzedanego popcornu', liczba_napojow AS 'Liczba sprzedanych napojów' FROM mydb.bilans_rachunku; ", DGVsales);
        }
    }
}
