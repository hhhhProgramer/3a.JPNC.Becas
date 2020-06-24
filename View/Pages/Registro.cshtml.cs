using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto {
    public class RegistroModel : PageModel {
        private readonly IRepository<Tutor> repository;
        private readonly IAccoutRepository ReposAccount;

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
            IAccoutRepository ReposAccount
        ) {
            this.repository = repository;
            this.ReposAccount = ReposAccount;
        }

        public void OnGet () { }

        public void OnPost () {
            if(!ReposAccount.IsRegister(account)){
                account.Status = true;
                account.student = this.student;
                this.Tutor.student = this.student;
                this.Tutor2.student = this.student;
                ReposAccount.Insert(account);
                repository.Insert (Tutor);
                repository.Insert (Tutor2); 
            }else{
                Console.WriteLine("Cuenta registrada");
            }
        }

    }
}