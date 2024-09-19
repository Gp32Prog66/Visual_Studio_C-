using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Visual_Studio_C_.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            /*

            //Conditional and Iteration Statement Demonstration

            //1. Short hand if else statement
            double decibal = 123;

            string loudness = (decibal > 120) ? "Shots Fired." : "No Gunfire detected.";

            //Console.Write(loudness); 

            //2. While Loop

            //Multiply
            int m = 0;
            while (m < 144)
            {
                Console.WriteLine(m);
                m++;
            }

            //3. For Loop
            for(int i = 12; i <= 144; i++)
            {
                Console.WriteLine(i);
            }

            //4. If Statement
            double z = 100;
            if (z > 90)
            {
                Console.WriteLine("Welcome to your 100s");
            }

            //5. Switch
            int option = 2;
            switch (option)
            {
                case 1:
                Console.WriteLine("Go To Sleep");
                break;
                case 2:
                Console.WriteLine("Ready To Learn");
                break;
                case 3:
                Console.WriteLine("Clear The Screen");

                Console.WriteLine("Click to Clear the Screen");


                break;
            }

            */
        }
    }
}
