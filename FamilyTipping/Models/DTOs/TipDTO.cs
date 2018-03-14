using PetaPoco.NetCore;

namespace FamilyTipping.Models.DTOs
{
    [TableName("Tip"), PrimaryKey("Id")]
    public class TipDTO
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int MatchId { get; set; }
        public int Prediction { get; set; }
    }
}
