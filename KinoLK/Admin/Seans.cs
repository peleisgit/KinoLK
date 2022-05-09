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
        int selectedIdHall;
        int selectedIdMovie;
        decimal selectedHour;
        decimal selectedMinute;
        string selectedTime;
        string selectedDay = "";
        int selectedIdSeansToRemove;
        int selectedIdMovieToRemove;
        int selectedIdHallToRemove;

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
            connection.GetDataGridView("SELECT idSeansu AS 'ID', Filmy_idFilmu AS 'Id filmu', Sala_idSali AS 'Id sali', data AS 'Data', godzina AS 'Godzina' FROM mydb.seanse;", DGVseanses);
        }






        public Seans()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            NumerucUpDownHour.Value = 0;
            NumerucUpDownMinute.Value = 0;
        }

        private void Seans_Load(object sender, EventArgs e)
        {
            GetDGVrooms();
            GetDGVmovies();
            GetDGVseanses();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            selectedHour = NumerucUpDownHour.Value;
            selectedMinute = NumerucUpDownMinute.Value;

            if (selectedIdHall == 0 || selectedIdMovie == 0 || selectedHour==0 || selectedDay == "")
            {
                MessageBox.Show("Uzupełnij brakujące informacje");
            }
            else
            {
               
                selectedTime = selectedHour.ToString() + ":" + selectedMinute.ToString();
                connection.AddNewSeans(selectedIdMovie, selectedIdHall, selectedDay, selectedTime);
                connection.GetDataGridView("SELECT idSeansu AS 'ID', Filmy_idFilmu AS 'Id filmu', Sala_idSali AS 'Id sali', 'data' AS Data, godzina AS 'Godzina' FROM mydb.seanse;", DGVseanses);
            }



            
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            connection.RemoveSeans(selectedIdSeansToRemove, selectedIdMovieToRemove, selectedIdHallToRemove);
            connection.GetDataGridView("SELECT idSeansu AS 'ID', Filmy_idFilmu AS 'Id filmu', Sala_idSali AS 'Id sali', 'data' AS Data, godzina AS 'Godzina' FROM mydb.seanse;", DGVseanses);
        }

        private void DGVrooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e != null)
            {
                selectedIdHall = (int)DGVrooms.Rows[e.RowIndex].Cells[0].Value;
            }
        }

       

        private void DGVmovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e != null)
            {
                selectedIdMovie = (int)DGVmovies.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void DGVseanses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e != null)
            {
                selectedIdSeansToRemove = (int)DGVseanses.Rows[e.RowIndex].Cells[0].Value;
                selectedIdMovieToRemove = (int)DGVseanses.Rows[e.RowIndex].Cells[1].Value;
                selectedIdHallToRemove = (int)DGVseanses.Rows[e.RowIndex].Cells[2].Value;
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {            
            selectedDay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
