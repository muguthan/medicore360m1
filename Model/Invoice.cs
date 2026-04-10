using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicore360m1.Model
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Column(TypeName = "decimal(18,2)")]  

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}