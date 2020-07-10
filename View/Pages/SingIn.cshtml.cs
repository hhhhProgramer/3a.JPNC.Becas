using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto
{
    public class SingInModel : PageModel
    {
        private readonly IRepository<Account> repository;

        [BindProperty]
        public Account account { get; set; }

        public SingInModel(IRepository<Account> repository)
        {
            this.repository = repository;
        }

        public void OnPost()
        {
            account.Type = (int) TypeAccount.STUDENT;
            account.Status = true;
            repository.Insert(account);
        }
    }
}
