using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLK.Class
{
    class TypeUser
    {
        private int id_type_user;
       
        private string type_user_name;

        public TypeUser(int id_type_user, string type_user_name)
        {
            this.id_type_user = id_type_user;
            this.type_user_name = type_user_name;
        }

        public int Id_type_user { get => id_type_user; set => id_type_user = value; }
        public string Type_user_name { get => type_user_name; set => type_user_name = value; }
    }
}
