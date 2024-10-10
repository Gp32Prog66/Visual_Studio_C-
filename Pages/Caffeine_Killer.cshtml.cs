using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Visual_Studio_C_.Pages
{
    public class CaffeineKillerModel : PageModel
    {
        public double? DrinkResults {get; set;}

        private readonly ILogger<IndexModel> _logger;

        public CaffeineKillerModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
                  
//Source Code of Caffeine Killer

      //Declare Variables
      double input, numDrinks;
      
    Console.WriteLine("Enter the amount of caffeine in milligrams");
    input = Convert.ToDouble(Console.ReadLine());
    
    //Calculations
    numDrinks = 10000 / input;
    
    numDrinks = Math.Ceiling(numDrinks);
    
    Console.WriteLine("Number of drinks that will kill you {0} ", numDrinks);

        }

        public void CaffeineResults()
        {

        }
    }
}