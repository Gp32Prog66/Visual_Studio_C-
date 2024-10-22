using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Visual_Studio_C_.Pages
{
    public class ThreeCsModel : PageModel
    {

        public string ProgramMessage { get; set;}
        private readonly ILogger<IndexModel> _logger;

        public ThreeCsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(int storageRequirements, int ramRequirements)
        {
            string @programMessage;

             

            if (storageRequirements >= 5)
            {
                programMessage = "Computer has enough storage for this program";
            }

            else
            {
                programMessage = "Computer doesn't have enough storage for this program";
            }

            if (ramRequirements >= 2)
            {
                programMessage = "This program should run fine";
            }
            else if (ramRequirements >= 1 && ramRequirements < 2)
            {
                programMessage = "This program may run sluggish. Lower the system settings to make it run smoother";
            }
            else
            {
                programMessage = "This program will not run.";
            }

           ProgramMessage = @programMessage;
        }
    }
}