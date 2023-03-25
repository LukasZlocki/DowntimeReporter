namespace DowntimeReporter.Model.Models
{
    public class Downtime
    {
        public int DowntimeId { get; set; }
        public DateTime Date { get; set; }
        public int LostMinutes { get; set; }

        // foreign key
        public int IdLevel0 { get; set; }
        Level0 lvl0;
        public int Level1Id { get; set; }
        Level1 lvl1;
        public int Level2Id { get; set; }
        Level2 lvl2;
        public int Level3Id { get; set; }
        Level3 lvl3;
    }
}
