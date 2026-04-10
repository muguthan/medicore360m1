using System.ComponentModel.DataAnnotations;
namespace medicore360m1.Model
{
    public class AuditLog
    {
        [Key]
        public int AuditId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
