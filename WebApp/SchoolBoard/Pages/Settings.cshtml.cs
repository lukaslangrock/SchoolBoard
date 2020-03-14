using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolBoard
{
    public class SettingsModel : PageModel
    {
        public Config config;

        public void OnGet()
        {
            // load config
            config = Configuration.Load();
        }

        [BindProperty]
        public string boardName { get; set; }
        public IActionResult OnPost()
        {
            // save new configuration
            config = Configuration.Load();
            config.Board.Name = boardName;
            Configuration.Save(config);

            // redirect to homepage
            return Redirect("/");
        }
    }
}