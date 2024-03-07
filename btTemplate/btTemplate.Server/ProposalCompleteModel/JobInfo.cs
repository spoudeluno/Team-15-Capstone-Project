namespace btTemplate.Server.ProposalCompleteModel
{
    public class JobInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool entityHasContact { get; set; }
        public int builderId { get; set; }
        public int jobStatus { get; set; }
        public string ownerName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }
        public string ownerCell { get; set; }
    }
}