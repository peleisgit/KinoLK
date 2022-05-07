using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoLK.Admin
{
    public partial class Seans : Form
    {
        ConnectionDB connection = new ConnectionDB();

        private void GetDGVrooms()
        {
            connection.GetDataGridView("SELECT idSali AS 'Id sali', ilosc_miejsc AS 'Ilość miejsc', nazwa_sali AS 'Nazwa sali' FROM mydb.sala;", DGVrooms);
        }

        private void GetDGVmovies()
        {
            connection.GetDataGridView("SELECT idFilmu AS 'Id filmu', nazwa_filmu AS 'Nazwa filmu', czas_trwania AS 'Czas trwania', gatunek AS 'Gatunek' FROM mydb.filmy;", DGVmovies);
        }

        private void GetDGVseanses()
        {
            connection.GetDataGridView("SELECT idSeansu AS 'ID', Filmy_idFilmu AS 'Id filmu', Sala_idSali AS 'Id sali', 'data' AS 'Data', godzina AS 'Godzina' FROM mydb.seanse;", DGVseanses);
        }






        public Seans()
        {
            InitializeComponent();
        }

        private void Seans_Load(object sender, EventArgs e)
        {
            GetDGVrooms();
            GetDGVmovies();
            GetDGVseanses();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
