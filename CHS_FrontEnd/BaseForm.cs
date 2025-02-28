using CHS.Client.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    public class BaseForm
    {
        public static int UserRole { get; private set; }  

        public static void SetUserRole(int role)
        {
            UserRole = role;
        }
      
    }
}
