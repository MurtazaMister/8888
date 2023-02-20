using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _8888.Models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }


        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        public long TagId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }

        public double TimeSpent { get; set; }


        [DataType(DataType.Date)]
        public DateTime Today { get; set; }
    }
}
