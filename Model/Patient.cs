using System.ComponentModel.DataAnnotations;

namespace medicore360m1.Model
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; }

        // Navigation Properties
        public ICollection<Record> Records { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}