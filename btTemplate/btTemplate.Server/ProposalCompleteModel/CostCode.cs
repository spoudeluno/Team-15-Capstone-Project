namespace btTemplate.Server.ProposalCompleteModel
{
    public class CostCode
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isFlatRateCostCode { get; set; }
        public bool isCustomerVariance { get; set; }
        public int costCategoryId { get; set; }
    }
}