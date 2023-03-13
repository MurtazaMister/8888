using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _8888.Models
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("SessionId")]
        public virtual Session? Session { get; set; }
        public long? SessionId { get; set; }

        public string? Comment { get; set; }
    }
}
