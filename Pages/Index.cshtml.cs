using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PSWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private string sasToken = "https://nmstgacct1.blob.core.windows.net/container1?sp=r&st=2021-02-24T17:06:44Z&se=2021-02-25T01:06:44Z&spr=https&sv=2020-02-10&sr=c&sig=CND75W9WltU00B9Xoy7zCs4JRtrIKUHu4X%2Ftk8biNhQ%3D";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var param = HttpContext.Request.Query["param"].ToString();
            if (param != string.Empty)
            {
                ViewData["QueryStringValue"] = param;
            }
            else
            {
                ViewData["QueryStringValue"] = "No Querystring value passed";
            }
        }
    }
}
