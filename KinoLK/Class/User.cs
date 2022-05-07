using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLK.Class
{
    class User
    {
        private int id_user;
        private string login;
        private string password;
        private string name;
        private string lastname;
        private double rate;
        private TimeSpan totalWorktime;

        public User()
        {

        }

       


        public User(int id_user, string login, string password, string name, string lastname, double rate, TimeSpan totalWorktime)
        {
            this.id_user = id_user;
            this.login = login;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
            this.rate = rate;
            this.totalWorktime = totalWorktime;            
        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public double Rate { get => rate; set => rate = value; }
        public TimeSpan TotalWorktime { get => totalWorktime; set => totalWorktime = value; }


    }
}
