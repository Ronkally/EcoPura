using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPuraLibreria
{
    public class Shared
    {
        public static bool Autorizacion(User user)
        {
            //rol 1 = admin
            if (user.Rol != 1)
            {
                return false;
            }
            return true;
        }

        public static bool InvalidString(string s)
        {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s))
                return true;

            return false;
        }
    }
}
