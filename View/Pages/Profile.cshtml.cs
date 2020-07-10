using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using Model;
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b

namespace Proyecto
{
    public class ProfileModel : PageModel
    {
<<<<<<< HEAD
        public Account account;
        
        [HttpGet]
        public void OnGet(Account account)
        {
            this.account = account;
            Console.WriteLine(account.Correo);
        }

       

=======
        
        public void OnGet()
        {
        }
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
    }
}
