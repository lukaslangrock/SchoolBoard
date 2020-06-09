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

        public List<ExamClass> classes { get; set; }
    }

    public class ExamClass
    {
        public string name { get; set; }

        public string teacher { get; set; }

        public int count { get; set; }

        public string room { get; set; }
    }
}
