using System.ComponentModel.DataAnnotations;

namespace medicore360m1.Model
{
    public class ComplianceReport
    {
        [Key]
        public int ReportId { get; set; }
        public string Scope { get; set; }
        public string Metrics { get; set; }
        public DateTime GeneratedDate { get; set; } = DateTime.UtcNow;
    }
}