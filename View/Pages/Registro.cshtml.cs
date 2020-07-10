using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto {
    public class RegistroModel : PageModel {
        private readonly IRepository<Tutor> repository;
        private readonly IAccoutRepository ReposAccount;
        private readonly IVisitRepository ReposVisit;

        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public Tutor Tutor { get; set; }

        [BindProperty]
        public Tutor Tutor2 { get; set; }
        [BindProperty]
        public Account account { get; set; }

        public RegistroModel (
            IRepository<Tutor> repository,
            IAccoutRepository ReposAccount,
            IVisitRepository ReposVisit
        ) {
            this.repository = repository;
            this.ReposAccount = ReposAccount;
            this.ReposVisit = ReposVisit;
        }

<<<<<<< HEAD
        public void OnGet (Account account) {
            this.account = account;
            if(string.IsNullOrEmpty(account.Correo))
                Console.WriteLine("Error");
            else
                Console.WriteLine(account.Correo);
         }

        public void OnPost () {
            Console.WriteLine(account.Correo);
            //generar una cuenata con sus relaciones
            
            account.Status = true; 
            account.Type = (int)TypeAccount.STUDENT;
            
            this.Tutor.student = this.student;
            this.Tutor2.student = this.student;
            Tutor.AccountId = account.Id;
            Tutor2.AccountId = account.Id;

            repository.Insert (Tutor);
            repository.Insert (Tutor2);
            ReposVisit.Resrved(account);
            Response.Redirect("../StudentIndex"); 
            
=======
        public void OnGet () { }

        public void OnPost () {
            
            //generar una cuenata con sus relaciones
            if(!ReposAccount.IsRegister(account)){
                account.Status = true;
                account.student = this.student;
                this.Tutor.student = this.student;
                this.Tutor2.student = this.student;
                
                ReposAccount.Insert(account);
                repository.Insert (Tutor);
                repository.Insert (Tutor2);
                ReposVisit.Resrved(account);
                Response.Redirect("../StudentIndex"); 
            }else{
                Console.WriteLine("Cuenta registrada");
            }
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
        }
        public ActionResult test(){
             Console.WriteLine(HttpContext.Session.GetString("Correo"));
            return RedirectToPage();
        }
    }
}