namespace DowntimeReporter.Model.Models
{
    public class Level2
    {
        public int Level2Id { get; set; }
        public string Description { get; set; }

        // foreign key
        public int Level3Id { get; set; }
    }
}
