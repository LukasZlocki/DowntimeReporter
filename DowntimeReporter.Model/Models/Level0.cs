namespace DowntimeReporter.Model.Models
{
    public class Level0
    {
        public int Level0Id { get; set; }
        public string Description { get; set; }

        // foreign key
        public int Level1Id { get; set; }
    }
}
