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
    public partial class Movies : Form
    {
        ConnectionDB connection = new ConnectionDB();
        int id_admina;
        int selected_id;
        private DateTime currectDate = DateTime.Now;

        private string title = ""; 
        private string productionDate = "";
        private string director = ""; 
        private string species = ""; 
        private int forAdults = 0; 
        private double duration = 0; 
        private double licencePrice = 0; 
        private DateTime datePurchase;


        public Movies(int id_admina)
        {
            this.id_admina = id_admina;
            InitializeComponent();
        }

        
        private void GetDGVmovies()
        {
            connection.GetDataGridView("SELECT idFilmu AS 'ID', nazwa_filmu AS 'Nazwa filmu', rok_produkcji AS 'Rok produkcji', rezyser AS 'Reżyser', gatunek AS 'Gatunek', dla_pelnoletnich AS 'Dla dorosłych', czas_trwania AS 'Czas trwania', cena_licencji AS 'Cena licencji', rok_wykupu_licencji AS 'Rok wykupu licencji' FROM mydb.filmy;", DGVmovies);
        }
        private void Movies_Load(object sender, EventArgs e)
        {
            GetDGVmovies();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            title = TextboxTitle.Text;
            director = TextboxDirector.Text;
            species = TextboxSpecies.Text;
            productionDate = DateTimePickerYearProduction.Value.ToString("yyyy-MM-dd");
            forAdults = CheckboxForAdult.Checked ? 1 : 0;
            duration = (double)NumerUpDownDuration.Value;
            licencePrice = (double)NumerUpDownPurchase.Value;         

            connection.AddNewMovie(title, productionDate, director, species, forAdults, duration, licencePrice, currectDate.ToString("yyyy-MM-dd"));
            GetDGVmovies();
        }

        private void BtnRemovieMovie_Click(object sender, EventArgs e)
        {
            connection.RemoveMovie(selected_id);
            GetDGVmovies();
        }

        private void DGVmovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e != null)
            {
                selected_id = (int)DGVmovies.Rows[e.RowIndex].Cells[0].Value;

                TextboxTitle.Text = DGVmovies.Rows[e.RowIndex].Cells[1].Value.ToString();              
                DateTimePickerYearProduction.Value = (DateTime)DGVmovies.Rows[e.RowIndex].Cells[2].Value;
                TextboxDirector.Text = DGVmovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                TextboxSpecies.Text = DGVmovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                CheckboxForAdult.Checked = (bool)DGVmovies.Rows[e.RowIndex].Cells[5].Value;
                NumerUpDownDuration.Value = (decimal)DGVmovies.Rows[e.RowIndex].Cells[6].Value;
                NumerUpDownPurchase.Value = (decimal)DGVmovies.Rows[e.RowIndex].Cells[7].Value; 
               
            }
        }
        
        private void BtnEditMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
