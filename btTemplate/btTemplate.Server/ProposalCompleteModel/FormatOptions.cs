namespace btTemplate.Server.ProposalCompleteModel
{
    public class FormatOptions
    {
        public int header { get; set; }
        public int body { get; set; }
        public bool showOwnerContactInfo { get; set; }
        public bool showAddress { get; set; }
        public bool showPrintoutInfo { get; set; }
        public int printoutType { get; set; }
        public bool hasSingleSelectCostTypes { get; set; }
    }
}