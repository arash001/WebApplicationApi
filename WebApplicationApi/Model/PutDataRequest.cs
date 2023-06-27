using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using WebApplicationApi.ViewModel;

namespace WebApplicationApi.Model
{
    public class PutDataRequest
    {
        [Key]
        public int Id { get; set; }
        public Fixtures Fixtures { get; set; }

        public string RequestId { get; set; }

        public DateTime MessageTime { get; set; }

        public bool TransmissionComplete { get; set; }

        public bool TransmissionSuspended { get; set; }
    }
}
