using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoCompany.Classes
{
    public class User
    {
        [JsonProperty("id")]
        private int id { get; set; }
        private string name { get; set; }
        [JsonProperty("first_surname")]
        private string firstSurname { get; set; }
        [JsonProperty("second_surname")]
        private string secondSurname { get; set; }

        [JsonProperty("phone")]
        private string phone { get; set; }

        [JsonProperty("email")]
        private string email { get; set; }

        [JsonProperty("dni")]
        private string dni { get; set; }
        [JsonProperty("is_admin")]
        private bool isAdmin { get; set; }
        [JsonProperty("is_active")]
        private bool isActive { get; set; }

        [JsonProperty("password")]
        private string password { get; set; }

        public int Id
        {
            get { return id; } // Método get para acceder al valor
            set { id = value; } // Método set para asignar un valor
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FirstSurname
        {
            get { return firstSurname; }
            set { firstSurname = value; }
        }
        public string SecondSurname
        {
            get { return secondSurname; }
            set { secondSurname = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin= value; }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //Constructor     
        public User(int id, string name, string firstSurname, string secondSurname,
            string phone, string email, string dni, bool is_admin, bool is_active, string password) { 
            this.id = id;
            this.name = name;
            this.firstSurname = firstSurname;
            this.secondSurname = secondSurname;
            this.phone = phone;
            this.email = email;
            this.dni = dni;
            this.isAdmin = is_admin;
            this.isActive = is_active;
            this.password = password;
        }
        
        public string ToString() {
            string user = id.ToString() + ", " + name + ", " + firstSurname + ", " + secondSurname + ", " +
                phone + ", " + email + ", " + dni + ", " + isAdmin + ", " + isActive + ", " +
                password + ".";
            return user;
        }
    }
}
