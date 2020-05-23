using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace SchoolBoard.Pages
{
    public class IndexModel : PageModel
    {
        public string dayOfWeek;
        public string dayOfMonth;
        public string dateOfYear;

        private readonly ILogger<IndexModel> _logger;

        private readonly IConfiguration Configuration;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public void OnGet()
        {
            switch (Configuration["Board:Day"])
            {
                case "Today":
                    SetDate();
                    break;

                case "Tomorrow":
                    SetDate(1);
                    break;
            }
        }

        private void SetDate(int addDays = 0)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            if (addDays != 0) { datetime = datetime.AddDays(addDays); }
            dayOfWeek = datetime.ToString("dddd");
            dayOfMonth = datetime.ToString("dd. MMMM");
            dateOfYear = datetime.ToShortDateString();
        }
    }
}
