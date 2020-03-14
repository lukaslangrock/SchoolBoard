using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
