namespace FamilyTipping.Models
{
    public class Tip
    {
        public int MatchId { get; set; }
        public int MemberId { get; set; }
        public Prediction Prediction { get; set; }
    }
}
