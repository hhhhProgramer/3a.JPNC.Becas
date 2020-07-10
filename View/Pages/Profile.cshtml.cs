using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto
{
    public class ProfileModel : PageModel
    {
        public Account account;
        
        [HttpGet]
        public void OnGet(Account account)
        {
            this.account = account;
            Console.WriteLine(account.Correo);
        }

       

    }
}
