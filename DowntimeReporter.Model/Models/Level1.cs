namespace DowntimeReporter.Model.Models
{
    public class Level1
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Level2> Level2List { get; set; }

        public Level0 Lvl0 { get; set; }
    }
}
