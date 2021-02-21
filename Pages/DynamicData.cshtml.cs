using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PSWebApp.Pages
{
    public class DynamicDataModel : PageModel
    {
        /// <summary>
        /// Message string
        /// </summary>
        public string Message { get; set; }
        private ILoggerFactory _Factory;

        public DynamicDataModel(ILoggerFactory factory)
        {
            _Factory = factory;
        }

        public void OnGet()
        {
            this.Message = DateTime.Now.Ticks.ToString();

            var logger = _Factory.CreateLogger("Pluralsight");

            logger.LogCritical("Logging a critical.");
            logger.LogError("Logging an error.");
            logger.LogWarning("Logging a warning.");

        }
    }
}
