using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Http;

namespace Proyecto
{
    public class LoginModel : PageModel
    {
        private readonly IAccoutRepository repository;
        public IEnumerable<Student> Students { get; private set; }

        [BindProperty]
        public string Correo { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(IAccoutRepository repository)
        {
            this.repository = repository;
        }

        public void OnGet()
        {

        }

        [HttpPost]
        public IActionResult OnPost(){
<<<<<<< HEAD
            IActionResult result =  RedirectToPage();
            
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
            Account account =  repository.Validate(new Account{
                Correo = this.Correo,
                Password = this.Password
            });


<<<<<<< HEAD
            if(account.Id > 0)
            {
                TypeAccount type = (TypeAccount)account.Type;

                switch(type)
                {
                    case TypeAccount.STUDENT:
                        result = RedirectToPage("Profile","OnGet",account);        
                    break;
                    
                    case TypeAccount.ADMIN:
                        result = RedirectToPage("EstudioSocioeconomico","OnGet",account);        
                    break;
                }                
            } 
                return result;
        }
=======
            if(account.Id > 0){
                HttpContext.Session.SetString("Correo",account.Correo);

                return RedirectToAction("Registro");
                
            }
                return RedirectToPage();
        }

>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
    }
}
