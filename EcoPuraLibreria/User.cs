using System;
using System.Data;

namespace EcoPuraLibreria
{
    public class User
    {
        public User(DataTable user)
        {
            UserName = user.Rows[0][1].ToString();
            Name = user.Rows[0][2].ToString();
            Contrasena = user.Rows[0][3].ToString();
            Email = user.Rows[0][4].ToString();
            Rol = Int16.Parse(user.Rows[0][5].ToString());
            Id = Int16.Parse(user.Rows[0][0].ToString());

        }
        public string UserName { get; private set; }
        public string Name { get; private set; }
        public string Contrasena { get; private set; }
        public string Email { get; private set; }
        public int Rol { get; set; }
        public int Id { get; set; }
    }
}
