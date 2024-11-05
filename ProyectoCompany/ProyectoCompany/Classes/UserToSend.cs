using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompany.Classes
{
    public class UserToSend
    {
        public int id { get; set; }
        public string name { get; set; }
        public string first_surname { get; set; }
        public string second_surname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string dni { get; set; }
        public bool is_admin { get; set; }
        public bool is_active { get; set; }
        public string password { get; set; }
        public UserToSend(string name, string firstSurname, string secondSurname,
            string phone, string email, string dni, bool is_admin, bool is_active, string password)
        {
            this.name = name;
            this.first_surname = firstSurname;
            this.second_surname = secondSurname;
            this.phone = phone;
            this.email = email;
            this.dni = dni;
            this.is_admin = is_admin;
            this.is_active = is_active;
            this.password = password;
        }
        public string ToString()
        {
            string user = id.ToString() + ", " + name + ", " + first_surname + ", " + second_surname + ", " +
                phone + ", " + email + ", " + dni + ", " + is_admin + ", " + is_active+ ", " +
                password + ".";
            return user;
        }
    }
}
