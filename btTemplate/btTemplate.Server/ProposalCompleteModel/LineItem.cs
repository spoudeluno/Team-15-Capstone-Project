namespace btTemplate.Server.ProposalCompleteModel
{
    public class LineItem
    {
        public int id { get; set; }
        public int builderId { get; set; }
        public int jobId { get; set; }
        public int lineItemType { get; set; }
        public int costCodeId { get; set; }
        public string costCodeTitle { get; set; }
        public int costCategoryId { get; set; }
        public object costItemId { get; set; }
        public string itemTitle { get; set; }
        public int? parentId { get; set; }
        public List<RelatedItem> relatedItems { get; set; }
        public List<int> costTypes { get; set; }
        public double unitCost { get; set; }
        public string unit { get; set; }
        public double quantity { get; set; }
        public double builderCost { get; set; }
        public int markupType { get; set; }
        public double markupPercent { get; set; }
        public double markupPerUnit { get; set; }
        public double markupAmount { get; set; }
        public double unitPrice { get; set; }
        public double ownerPrice { get; set; }
        public double amountInvoiced { get; set; }
        public string description { get; set; }
        public DateTime dateAdded { get; set; }
        public int worksheetDisplayOrder { get; set; }
        public object taxGroupId { get; set; }
        public double totalWithTax { get; set; }
    }
}