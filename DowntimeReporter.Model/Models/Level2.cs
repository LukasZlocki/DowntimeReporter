namespace DowntimeReporter.Model.Models
{
    public class Level2
    {
        public int Id { get; set; }
        public string Description { get; set; }

        List<Level3> Level3List { get; set; }
        // foreign key
        Level1 Lvl1 { get; set; }
    }
}
