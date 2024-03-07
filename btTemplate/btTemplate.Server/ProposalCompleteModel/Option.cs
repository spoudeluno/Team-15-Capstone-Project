namespace btTemplate.Server.ProposalCompleteModel
{
    public class Option
    {
        public object name { get; set; }
        public List<Option> options { get; set; }
        public int type { get; set; }
        public object key { get; set; }
        public int id { get; set; }
        public object secondaryName { get; set; }
        public bool selected { get; set; }
        public object extraData { get; set; }
        public bool disabled { get; set; }
    }
}