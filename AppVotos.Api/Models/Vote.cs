namespace AppVotos.Api.Models
{
    public class Vote 
    {
        public int Id {get; set;}
        public int CandidateId { get; set; }
        public int VotingTable { get; set; }
        public int VotesCount { get; set; }
    }
}