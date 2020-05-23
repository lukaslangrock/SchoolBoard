using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SchoolBoard
{
    public class SettingsModel : PageModel
    {
        private readonly IConfiguration Configuration;

        public SettingsModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void OnGet()
        {
            
        }

        [BindProperty]
        public string boardName { get; set; }
        public IActionResult OnPost()
        {
            // save new configuration
            //TODO: Implement save mechanics using appsettings.json

            // redirect to homepage
            return Redirect("/");
        }
    }
}
