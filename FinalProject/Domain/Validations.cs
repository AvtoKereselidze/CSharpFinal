using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Domain
{
    class Validations
    {
        public Validations()
        {

        }

        static public bool isLoggedIn = false;

        public static void LoginValidation(List<User> users, string username, string password)
        {
            

            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    isLoggedIn = true;
                }
            }

            if (isLoggedIn)
            {
                Console.WriteLine("Successesful login!");
            }
            else
            {
                Console.WriteLine("Wrong Username or Password!");
            }
        }

  
    }
}
