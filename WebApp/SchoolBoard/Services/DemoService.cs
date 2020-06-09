using SchoolBoard.Models;

namespace SchoolBoard.Services
{
    public class DemoService
    {
        public Alerts GetAlerts()
        {
            Alerts alerts = new Alerts();

            return alerts;
        }

        public Exams GetExams()
        {
            Exams exams = new Exams();

            return exams;
        }

        public Representations GetRepresentations()
        {
            Representations representations = new Representations();

            return representations;
        }
    }
}
