using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Visual_Studio_C_.Pages
{
    public class LinkedListModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public LinkedListModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            /*

            LinkedList<String> csharp_linked_list = new LinkedList<String>();

            

            csharp_linked_list.AddFirst("Keyboard");
            csharp_linked_list.Append("Mouse");
            csharp_linked_list.AddLast("Mouse Pad");
            csharp_linked_list.Append("Monitor");
    
            //Print String
            foreach (string str in csharp_linked_list)
            {
                Console.WriteLine(str);
            }
            */
        }
    }
}