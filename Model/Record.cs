using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicore360m1.Model
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required]
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        // Navigation Property
        public Patient Patient { get; set; }
    }
}