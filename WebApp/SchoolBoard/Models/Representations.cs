using System.Collections.Generic;

namespace SchoolBoard.Models
{
    public class Representations
    {
        public List<TeacherTable> teacherTables { get; set; }
    }

    public class TeacherTable
    {
        public string name { get; set; }

        public List<TeacherHour> hours { get; set; }
    }

    public class TeacherHour
    {
        public int hour { get; set; }

        public string className { get; set; }

        public string representingTeacherName { get; set; }

        public string room { get; set; }

        public string note { get; set; }
    }
}
