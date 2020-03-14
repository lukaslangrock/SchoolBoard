using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public Config config;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            config = Configuration.Load();
            switch (config.Board.Day)
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
