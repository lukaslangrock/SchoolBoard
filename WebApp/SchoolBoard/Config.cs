namespace SchoolBoard
{
    public class Config
    {
        public Board Board { get; set; }
    }

    public class Board
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public bool Alerts { get; set; }
        public bool Exams { get; set; }
        public bool Representations { get; set; }
    }
}
