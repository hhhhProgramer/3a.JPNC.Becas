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
            if(id <= 0) id = 1;
            this.visit = ReposVisits.GetComplete(id);
        }

    }
}
