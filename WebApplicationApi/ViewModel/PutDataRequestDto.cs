using System.Xml.Serialization;

namespace WebApplicationApi.ViewModel
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(PutDataRequest));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (PutDataRequest)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Fixture")]
    public class FixtureDto
    {

        [XmlAttribute(AttributeName = "MatchId")]
        public string MatchId { get; set; }

        [XmlAttribute(AttributeName = "DlProviderId")]
        public int DlProviderId { get; set; }

        [XmlAttribute(AttributeName = "CompetitionId")]
        public string CompetitionId { get; set; }

        [XmlAttribute(AttributeName = "CompetitionName")]
        public string CompetitionName { get; set; }

        [XmlAttribute(AttributeName = "CompetitionType")]
        public string CompetitionType { get; set; }

        [XmlAttribute(AttributeName = "MatchDayId")]
        public string MatchDayId { get; set; }

        [XmlAttribute(AttributeName = "MatchDay")]
        public int MatchDay { get; set; }

        [XmlAttribute(AttributeName = "MatchType")]
        public string MatchType { get; set; }

        [XmlAttribute(AttributeName = "Season")]
        public string Season { get; set; }

        [XmlAttribute(AttributeName = "SeasonId")]
        public string SeasonId { get; set; }

        [XmlAttribute(AttributeName = "PlannedKickoffTime")]
        public DateTime PlannedKickoffTime { get; set; }

        [XmlAttribute(AttributeName = "StadiumName")]
        public string StadiumName { get; set; }

        [XmlAttribute(AttributeName = "StadiumId")]
        public string StadiumId { get; set; }

        [XmlAttribute(AttributeName = "HomeTeamName")]
        public string HomeTeamName { get; set; }

        [XmlAttribute(AttributeName = "HomeTeamId")]
        public string HomeTeamId { get; set; }

        [XmlAttribute(AttributeName = "GuestTeamName")]
        public string GuestTeamName { get; set; }

        [XmlAttribute(AttributeName = "GuestTeamId")]
        public string GuestTeamId { get; set; }

        [XmlAttribute(AttributeName = "MatchDateFixed")]
        public bool MatchDateFixed { get; set; }

        [XmlAttribute(AttributeName = "StartDate")]
        public DateTime StartDate { get; set; }

        [XmlAttribute(AttributeName = "EndDate")]
        public DateTime EndDate { get; set; }
    }

    [XmlRoot(ElementName = "Fixtures")]
    public class FixturesDto
    {

        [XmlElement(ElementName = "Fixture")]
        public List<FixtureDto> Fixture { get; set; }

        [XmlAttribute(AttributeName = "FeedType")]
        public string FeedType { get; set; }
    }

    [XmlRoot(ElementName = "PutDataRequest")]
    public class PutDataRequestDto
    {

        [XmlElement(ElementName = "Fixtures")]
        public FixturesDto Fixtures { get; set; }

        [XmlAttribute(AttributeName = "RequestId")]
        public string RequestId { get; set; }

        [XmlAttribute(AttributeName = "MessageTime")]
        public DateTime MessageTime { get; set; }

        [XmlAttribute(AttributeName = "TransmissionComplete")]
        public bool TransmissionComplete { get; set; }

        [XmlAttribute(AttributeName = "TransmissionSuspended")]
        public bool TransmissionSuspended { get; set; }
    }


}
