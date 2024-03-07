namespace btTemplate.Server.ProposalCompleteModel
{
    public class BuilderInfo
    {
        public required string companyName { get; set; }
        public required string website { get; set; }
        public required string phone { get; set; }
        public required string fax { get; set; }
        public required object timeZone { get; set; }
        public required object timeZoneList { get; set; }
        public required string country { get; set; }
        public required object address { get; set; }
        public required string logo { get; set; }
        public required List<string> additionalFields { get; set; }
    }
}