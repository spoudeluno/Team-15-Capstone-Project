namespace btTemplate.Server.ProposalCompleteModel
{
    public class Proposal
    {
        public int builderId { get; set; }
        public int userId { get; set; }
        public int jobId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public object approvalDeadline { get; set; }
        public string introductionText { get; set; }
        public string closingText { get; set; }
        public ColumnsToDisplay columnsToDisplay { get; set; }
        public JobInfo jobInfo { get; set; }
        public BuilderInfo builderInfo { get; set; }
        public BuilderAddress builderAddress { get; set; }
        public JobAddress jobAddress { get; set; }
        public ContactAddress contactAddress { get; set; }
        public bool showContactAddress { get; set; }
        public bool displayToOwner { get; set; }
        public List<CostCode> costCodes { get; set; }
        public List<LineItem> lineItems { get; set; }
        public FormatOptions formatOptions { get; set; }
        public string disclaimer { get; set; }
    }
}