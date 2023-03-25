namespace DowntimeReporter.Model.Models
{
    public class Downtime
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int LostMinutes { get; set; }

        public ShiftCard ShiftCard { get; set; }
        public Level0 Level0 { get; set; }
        public Level1 Level1 { get; set;}
        public Level2 Level2 { get; set;}
        public Level3 Level3 { get; set;}


    }
}
