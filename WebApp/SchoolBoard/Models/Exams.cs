using System.Collections.Generic;

namespace SchoolBoard.Models
{
    public class Exams
    {
        public List<ExamTable> examTables { get; set; }
    }

    public class ExamTable
    {
        public string block { get; set; }

        public List<Class> classes { get; set; }
    }

    public class Class
    {
        public string name { get; set; }

        public string teacher { get; set; }

        public int count { get; set; }

        public string room { get; set; }
    }
}
