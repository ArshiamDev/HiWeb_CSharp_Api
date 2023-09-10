using System.ComponentModel.DataAnnotations;

namespace HiWebAPI.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        public string lastGiftTimeString { get; set; }
        public DateTime lastGiftTimeDate { get; set; }
        public int totalNet { get; set; }
        public int remainNet { get; set; }
        public int giftNet { get; set; }
    }
}