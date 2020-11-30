using System;
using System.Collections.Generic;
using System.Text;

namespace Exercici3VideosFases_2.Clases
{
    public class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatRegister { get; set; }



        public User()
        {

        }


        public static List<User> uList = new List<User>
        {
           new User {Name="Joaquina", Surname="Ruano",Username="jruanomed",Password="jruanomed" },
           new User {Name= "Javier", Surname= "Perez", Username= "jperez", Password= "jperez" },
           new User {Name= "Admin", Surname= "Admin", Username= "admin", Password= "admin"}};
    }






}

