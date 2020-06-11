using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolBoard.Helpers;
using SchoolBoard.Models;
using SchoolBoard.Services;
using System;

namespace SchoolBoard.Pages
{
    public class IndexModel : PageModel
    {
        public string dayOfWeek;
        public string dayOfMonth;
        public string dateOfYear;

        public Alerts alerts;
        public Exams exams;
        public Representations representations;

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

            LoadData(); // Get school data from service
        }

        private void SetDate(int addDays = 0)
        {
            DateTime datetime = new DateTime();
            datetime = TimeHelper.GetLocalTime(Configuration["Board:Timezone"]);
            if (addDays != 0) { datetime = datetime.AddDays(addDays); }
            dayOfWeek = datetime.ToString("dddd");
            dayOfMonth = datetime.ToString("dd. MMMM");
            dateOfYear = datetime.ToShortDateString();
        }

        private void LoadData()
        {
            // Switch this to your custom service to change the data on the web page
            DemoService service = new DemoService();

            // only get the needed information for this board
            if (Convert.ToBoolean(Configuration["Board:Alerts"])) { alerts = service.GetAlerts(); }
            if (Convert.ToBoolean(Configuration["Board:Exams"])) { exams = service.GetExams(); }
            if (Convert.ToBoolean(Configuration["Board:Representations"])) { representations = service.GetRepresentations(); }
        }
    }
}
