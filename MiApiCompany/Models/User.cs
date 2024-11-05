namespace MiApiCompany.Models
{
    public class User
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
    }
}
