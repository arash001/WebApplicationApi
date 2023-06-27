using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WebApplicationApi.Model
{
    public class Fixtures
    {
        [Key]
        public int Id { get; set; }
        public List<Fixture> Fixture { get; set; }

        public string FeedType { get; set; }
    }
}
