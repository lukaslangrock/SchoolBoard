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

        // types are the names of bootstrap alert classes (https://getbootstrap.com/docs/4.0/components/alerts/)
        public string type { get; set; }
    }
}
