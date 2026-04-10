using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicore360m1.Model
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        [Required]
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        // Navigation Property
        public Patient Patient { get; set; }
    }
}