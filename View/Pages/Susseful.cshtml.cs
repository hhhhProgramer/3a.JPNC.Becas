using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto
{
    public class SussefulModel : PageModel
    {
        public Visit visit { get; set; }
        private readonly IVisitRepository ReposVisits;

        public SussefulModel(IVisitRepository ReposVisits)
        {
            this.ReposVisits = ReposVisits;
        }
        
        public void OnGet(int id)
        {
            this.visit = ReposVisits.GetComplete(id);
            if(visit.Id > 0) Console.WriteLine("Correcto");
        }

    }
}
