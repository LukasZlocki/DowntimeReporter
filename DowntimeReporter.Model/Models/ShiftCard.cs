namespace DowntimeReporter.Model.Models
{
    public class ShiftCard
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MinutesLost { get; set; }

        List<Downtime> DowntimesList { get; set; }
    }
}
