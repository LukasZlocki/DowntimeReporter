namespace DowntimeReporter.Model.Models
{
    public class Level1
    {
        public int Level1Id { get; set; }
        public string Description { get; set; }

        // foreign key
        public int Level2Id { get; set; }
    }
}
