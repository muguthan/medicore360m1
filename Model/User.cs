using System.ComponentModel.DataAnnotations;

namespace medicore360m1.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigation Properties
        public ICollection<AuditLog> AuditLogs { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}