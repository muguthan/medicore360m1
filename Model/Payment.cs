using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicore360m1.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }

        [Column(TypeName = "decimal(18,2)")]  

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }

        // Navigation Property
        public Invoice Invoice { get; set; }
    }
}