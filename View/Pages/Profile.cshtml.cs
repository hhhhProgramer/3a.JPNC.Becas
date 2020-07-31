using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto
{
    public class ProfileModel : PageModel
    {
        public Account account;
        public Tutor Tutor;
        private readonly IVisitRepository ReposVisits;
        private readonly IRepository<Tutor> ReposTutor;

        public ProfileModel(IVisitRepository ReposVisits,IRepository<Tutor> ReposTutor)
        {
            this.ReposVisits = ReposVisits;
            this.ReposTutor = ReposTutor;
        }
        
        public void OnGet(Account account)
        {
            this.account = account;
            
            var Register =  ReposVisits.GetAllComplete()
                            .Any(
                                x => x.Tutor.Account.Correo == account.Correo &&
                                x.EconomicStudy.Status == (int)StudyStatus.REGISTER ||
                                x.EconomicStudy.Status == (int)StudyStatus.PROCESS
                                );

            Console.WriteLine(Register);

            if(Register){
                Response.Redirect("../Alert");
                Console.WriteLine(Register);
            }
                
            
            Console.WriteLine(account.Correo);
        }

    }
}
