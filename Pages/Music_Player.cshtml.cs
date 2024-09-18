using System.Media;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Visual_Studio_C_.Pages
{
    public class MusicPlayerModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MusicPlayerModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

          
        }
    }
}