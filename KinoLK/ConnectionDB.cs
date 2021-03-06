using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using KinoLK.Class;
using System.Globalization;

namespace KinoLK
{
    class ConnectionDB
    {
        private MySqlConnection connectionDB;
        private string server;
        private string database;
        private string uid;
        private string password;



        public ConnectionDB()
        {
            Initialize();
        }


        private void Initialize()
        {
            server = "localhost";
            database = "mydb";
            uid = "root";
            password = "123456";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connectionDB = new MySqlConnection(connectionString);
        }



        private bool OpenConnection()
        {
            try
            {
                connectionDB.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex);
                return false;
            }
        }


        private bool CloseConnection()
        {
            try
            {
                connectionDB.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


        public int CheckLogin(string login, string password)
        {

            MySqlCommand connectionCheckLogin = new MySqlCommand("SELECT IdUser FROM mydb.uzytkownik WHERE Login='" + login + "' AND haslo='" + password + "';", connectionDB);
            MySqlDataReader dd;

            int id;


            OpenConnection();
            dd = connectionCheckLogin.ExecuteReader();

            if (dd.Read())
            {
                id = dd.GetInt32(0);
            }
            else
            {
                id = 0;
            }

            dd.Close();
            CloseConnection();
            return id;
        }



        public int CheckTypeUser(int id)
        {
            MySqlCommand connectionCheckTypeUser = new MySqlCommand("SELECT czy_admin FROM mydb.uzytkownik WHERE IdUser=" + id + ";", connectionDB);
            MySqlDataReader dd;
            int type;
            OpenConnection();
            dd = connectionCheckTypeUser.ExecuteReader();

            if (dd.Read())
            {
                type = dd.GetInt32(0);
            }
            else
            {
                type = 0;
            }

            CloseConnection();
            return type;
        }

        public User UserById(int id)
        {
            MySqlCommand connectionUserById = new MySqlCommand("SELECT * FROM mydb.uzytkownik WHERE IdUser=" + id + ";", connectionDB);
            MySqlDataReader dr;
            User user = new User();
            int h = 0, m = 0, s = 0;
            OpenConnection();
            dr = connectionUserById.ExecuteReader();

            while (dr.Read())
            {
                int idUserDB = (int)(dr["IdUser"]);
                string loginDB = dr["login"].ToString();
                string passwordnDB = dr["haslo"].ToString();
                string nameDB = dr["imie"].ToString();
                string lastanameDB = dr["nazwisko"].ToString();
                double rateDB = dr.GetDouble(6);
                string totalWorktimeDB = dr["laczny_czas_pracy"].ToString();
                string[] tab = totalWorktimeDB.Split(':');

                for (int i = 0; i < tab.Length; i++)
                {
                    if (i == 0)
                    {
                        h = h + Int32.Parse(tab[i]);
                    }
                    if (i == 1)
                    {
                        m = m + Int32.Parse(tab[i]);
                    }
                    if (i == 2)
                    {
                        s = s + Int32.Parse(tab[i]);
                    }
                }

                TimeSpan totalWorktime = new TimeSpan(h, m, s);


                user = new User(idUserDB, loginDB, passwordnDB, nameDB, lastanameDB, rateDB, totalWorktime);
            }
            dr.Close();
            CloseConnection();

            return user;
        }


        public void GetDataGridView(string command, DataGridView datagridView)
        {
            try
            {
                OpenConnection();

                BindingSource bindingSource1 = new BindingSource();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, connectionDB);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                datagridView.DataSource = bindingSource1;

                CloseConnection();

            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void SendIncome(string currentData, int numberTransaction, decimal income = 0, int numberTicketsSold = 0, int numberPopcorns = 0, int numberDrinks = 0)
        {
            MySqlCommand connectionSendIncome = new MySqlCommand("INSERT INTO `mydb`.`bilans_rachunku` (`data`, `przychody`, `ilosc_sprzedanych_biletow`, `ilosc_transakcji`, `liczba_popcornu`,`liczba_napojow`) VALUES('" + currentData + "', CAST('" + income.ToString().Replace(',','.') + "' as decimal), '" + numberTicketsSold + "', '" + numberTransaction + "', '" + numberPopcorns + "', '" + numberDrinks + "'); ", connectionDB);


            OpenConnection();
            connectionSendIncome.ExecuteNonQuery();
            CloseConnection();
        }

        public void SendCost(string currentData, double dailyWage)
        {
            decimal dailyWageDecimal = Convert.ToDecimal(dailyWage);
            decimal dailyWageRounded = Math.Round(dailyWageDecimal, 2);
          


            MySqlCommand connectionDendIncome = new MySqlCommand("INSERT INTO `mydb`.`bilans_rachunku` (`data`, `koszty`) VALUES('" + currentData + "','" + dailyWageRounded.ToString().Replace(',', '.') + "'); ", connectionDB);          

            OpenConnection();
            connectionDendIncome.ExecuteNonQuery();
            CloseConnection();
        }

        public void RegisterWorkingHours(int id, string workTimer, string currentDate)
        {
            MySqlCommand connectionDendIncome = new MySqlCommand("INSERT INTO `mydb`.`godziny_pracy` (`czas`, `data_dodania_godzin_pracy`, `Uzytkownik_idUser`) VALUES('" + workTimer + "', '" + currentDate + "', '" + id + "'); ", connectionDB);


            OpenConnection();
            connectionDendIncome.ExecuteNonQuery();
            CloseConnection();

        }


        public TimeSpan GetRegisterWorkingHours(int id)
        {
            MySqlCommand connectionGetRegisterWorkingHours = new MySqlCommand("SELECT * FROM mydb.godziny_pracy WHERE Uzytkownik_idUser=" + id + ";", connectionDB);
            MySqlDataReader dr;
            User user = new User();
            string timeWorkDB = "";
            string[] tab;
            int h = 0, m = 0, s = 0;
            OpenConnection();
            dr = connectionGetRegisterWorkingHours.ExecuteReader();
            while (dr.Read())
            {
                timeWorkDB = dr["czas"].ToString();
                tab = timeWorkDB.Split(':');
                for (int i = 0; i < tab.Length; i++)
                {
                    if (i == 0)
                    {
                        h = h + Int32.Parse(tab[i]);
                    }
                    if (i == 1)
                    {
                        m = m + Int32.Parse(tab[i]);
                    }
                    if (i == 2)
                    {
                        s = s + Int32.Parse(tab[i]);
                    }
                }
            }
            CloseConnection();

            TimeSpan timeSpan = new TimeSpan(h, m, s);

            return timeSpan;
        }


        public void UpdateRegisterWorkingHours(int id, string totalWorktime)
        {
            try
            {
                MySqlCommand connectionUpdateRegisterWorkingHours = new MySqlCommand("UPDATE `mydb`.`uzytkownik` SET laczny_czas_pracy='" + totalWorktime + "' WHERE(`idUser` ='" + id + "'); ", connectionDB);
                OpenConnection();
                connectionUpdateRegisterWorkingHours.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

       


        public void AddNewEmployee(string login, string password, string lastname, string name, string position, double rate)
        {
            MySqlCommand connectionAddNewEmployee = new MySqlCommand("INSERT INTO `mydb`.`uzytkownik` (`login`, `haslo`, `nazwisko`, `imie`, `stanowisko`, `stawka`, `czy_admin`) VALUES('" + login + "', '" + password + "', '" + lastname + "', '" + name + "','" + position + "','" + rate + "','0'); ", connectionDB);
            try
            {
                if (OpenConnection() == true)
                {
                    connectionAddNewEmployee.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public void RemoveEmployee(int id)
        {           
            MySqlCommand connectionRemoveEmployee = new MySqlCommand("DELETE FROM `mydb`.`uzytkownik` WHERE (`idUser` ='" + id + "');", connectionDB);   

            if (OpenConnection() == true)
            {
                connectionRemoveEmployee.ExecuteNonQuery();               
                CloseConnection();
            }
        }

       

        public void EditEmployee(int id, string login, string haslo, string lastname, string name, string position, decimal rate)
        {          

            try
            {
                MySqlCommand connectionEditEmployee = new MySqlCommand("UPDATE `mydb`.`uzytkownik` SET login='" + login + "',haslo= '" + haslo + "',nazwisko= '" + lastname + "',imie= '" + name + "',stanowisko= '" + position + "',stawka= '" + rate + "' WHERE(`idUser` ='" + id + "'); ", connectionDB);
                OpenConnection();
                connectionEditEmployee.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }




        public void AddNewMovie(string title, string productionDate, string director, string species, int forAdults, double duration, double licencePrice, string datePurchase)
        {
         MySqlCommand connectionAddNewMovie = new MySqlCommand("INSERT INTO `mydb`.`filmy` (`nazwa_filmu`, `rok_produkcji`, `rezyser`, `gatunek`, `dla_pelnoletnich`, `czas_trwania`, `cena_licencji`, `rok_wykupu_licencji`) VALUES('" + title + "', '" + productionDate + "','" + director + "','" + species + "','" + forAdults + "','" + duration + "', '" + licencePrice + "','" + datePurchase + "'); ", connectionDB);

            try
            {
                if (OpenConnection() == true)
                {
                    connectionAddNewMovie.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


        public void RemoveMovie(int id)
        {
            MySqlCommand connectionRemoveMovie = new MySqlCommand("DELETE FROM `mydb`.`filmy` WHERE (`idFilmu` ='" + id + "');", connectionDB);
           
            if (OpenConnection() == true)
            {
                connectionRemoveMovie.ExecuteNonQuery();
                CloseConnection();
            }
        }
              

        public List<string> GetMoviesToDashboard(string date)
        {
            List<string> movies = new List<string>();
            MySqlDataReader dr;
            MySqlCommand connectionGetMoviesToCombobox = new MySqlCommand("SELECT mydb.filmy.nazwa_filmu as 'film' FROM mydb.seanse inner join mydb.filmy on mydb.seanse.Filmy_idFilmu=mydb.filmy.idFilmu where mydb.seanse.data='" + date + "';", connectionDB);
           

            OpenConnection();
            dr = connectionGetMoviesToCombobox.ExecuteReader();

            while (dr.Read())
            {
                movies.Add(dr["film"].ToString());
            }

            
            CloseConnection();

            return movies;
        }

        public List<string> GetHoursMovieToDashbord(string movies,string date)
        {
            List<string> hours = new List<string>();
            MySqlDataReader dr;
            MySqlCommand connectionGetHoursMovieToDashbord = new MySqlCommand("SELECT mydb.seanse.godzina as 'godzina' FROM mydb.seanse inner join mydb.filmy on mydb.seanse.Filmy_idFilmu=mydb.filmy.idFilmu where mydb.seanse.data='" + date + "' and mydb.filmy.nazwa_filmu='"+movies+"';", connectionDB);


            OpenConnection();
            dr = connectionGetHoursMovieToDashbord.ExecuteReader();

            while (dr.Read())
            {
                hours.Add(dr["godzina"].ToString());
            }

            CloseConnection();

            return hours;
        }


        public string getInfoAboutMovie(string movie, string snapshot)
        {
            string category = "";
            MySqlCommand getInfoAboutMovie = new MySqlCommand("SELECT " + snapshot + " FROM mydb.filmy WHERE nazwa_filmu='" + movie + "';", connectionDB);
            MySqlDataReader dr;


            OpenConnection();
            dr = getInfoAboutMovie.ExecuteReader();

            if (dr.Read())
            {
                category = dr[snapshot].ToString();
            }


            dr.Close();
            CloseConnection();

            return category;
        }

        public List<string> GetInfoAboutHalls(string movie, string hour, string day)
        {
            List<string> halls = new List<string>();
            MySqlCommand getInfoAboutHalls = new MySqlCommand("SELECT nazwa_sali FROM mydb.sala INNER JOIN mydb.seanse ON sala.idSali=seanse.Sala_idSali INNER JOIN mydb.filmy ON mydb.seanse.Filmy_idFilmu=filmy.idFilmu WHERE seanse.data='" + day + "' AND seanse.godzina='" + hour + "' AND filmy.nazwa_filmu='" + movie + "';", connectionDB);

            MySqlDataReader dr;


            OpenConnection();
            dr = getInfoAboutHalls.ExecuteReader();

            if (dr.Read())
            {
                halls.Add(dr["nazwa_sali"].ToString());
            }


            dr.Close();
            CloseConnection();

            return halls;
        }

        public List<int> GetIdsSeans(string movie, string hall, string day, string hour)
        {
            List<int> ids = new List<int>();
            MySqlCommand getIdsSeans = new MySqlCommand("SELECT idSali, idFilmu, idSeansu FROM mydb.seanse INNER JOIN mydb.filmy ON seanse.Filmy_idFilmu=filmy.idFilmu INNER JOIN sala ON seanse.Sala_idSali=sala.idSali WHERE filmy.nazwa_filmu='" + movie + "' AND sala.nazwa_sali='" + hall + "' AND seanse.data='" + day + "' AND seanse.godzina='" + hour + "'", connectionDB);

            MySqlDataReader dr;
            OpenConnection();

            dr = getIdsSeans.ExecuteReader();

            if (dr.Read())
            {
                 ids.Add((int)dr["idSeansu"]);
                 ids.Add((int)dr["idSali"]);
                 ids.Add((int)dr["idFilmu"]);
                
            }


            CloseConnection();

            return ids;
        }



       public void AddTicketsToDB(List<int> ids)
        {
            MySqlCommand connectionAddTicketsToDB = new MySqlCommand("INSERT INTO `mydb`.`bilet` (`cena`, `Seanse_idSeansu`, `Seanse_Filmy_idFilmu`, `Seanse_Sala_idSali`) VALUES ('30', '"+ ids[0] + "', '" + ids[2] + "', '" + ids[1] + "');", connectionDB);
            OpenConnection();

            try
            {                
                connectionAddTicketsToDB.ExecuteNonQuery();               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();

        }


        public void AddNewSeans(int idMovie, int idHall, string date, string hour)
        {       

            MySqlCommand connectionAddNewSeans = new MySqlCommand("INSERT INTO `mydb`.`seanse` (`Filmy_idFilmu`, `Sala_idSali`, `data`, `godzina`) VALUES('" + idMovie + "', '" + idHall + "', '" + date + "', '" + hour + "');", connectionDB);


            try
            {
                if (OpenConnection() == true)
                {
                    connectionAddNewSeans.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


        
         



        public void RemoveSeans(int idSeans, int idMovie, int idHall)
        {
            MySqlCommand connectionRemoveSeans = new MySqlCommand("DELETE FROM `mydb`.`seanse` WHERE (`idSeansu` ='" + idSeans + "') AND  (`Filmy_idFilmu` ='" + idMovie + "') AND (`Sala_idSali` ='" + idHall + "');", connectionDB);

            if (OpenConnection() == true)
            {
                connectionRemoveSeans.ExecuteNonQuery();
                CloseConnection();
            }
        }




    } 
}
