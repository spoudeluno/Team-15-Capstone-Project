namespace btTemplete.Server.TemplateModels
{
    public class Proposal
    {
        public required int ProposalID {  get; set; }
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public int? Amount { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

    }
}
