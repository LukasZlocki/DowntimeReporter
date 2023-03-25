namespace DowntimeReporter.Model.Models
{
    public class Level3
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Level2 Lvl2 { get; set; }
    }
}
