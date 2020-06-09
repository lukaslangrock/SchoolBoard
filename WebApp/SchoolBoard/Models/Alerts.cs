using System.Collections.Generic;

namespace SchoolBoard.Models
{
    public class Alerts
    {
        public List<AlertMessage> alertMessages { get; set; }
    }

    public class AlertMessage
    {
        public string message { get; set; }

        public string type { get; set; }
    }
}
