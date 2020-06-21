using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Control;

namespace Proyecto
{
    public class LoginModel : PageModel
    {
        private readonly IRepository<Student> repository;
        public IEnumerable<Student> Students { get; private set; }

        [BindProperty]
        public int Correo { get; set; }
        [BindProperty]
        public int Password { get; set; }

        public LoginModel(IRepository<Student> repository)
        {
            this.repository = repository;
        }

        public void OnGet()
        {

        }

        public void OnPost(){
            
        }

    }
}
