using System.ComponentModel.DataAnnotations;

namespace DowntimeReporter.Model.Models
{
    public class Level0
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Level1> Level1List { get; set; }
    }
}
