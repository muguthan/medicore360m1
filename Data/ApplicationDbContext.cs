using medicore360m1.Model;
using Microsoft.EntityFrameworkCore;

namespace medicore360m1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<ComplianceReport> ComplianceReports { get; set; }
        public DbSet<KPIReport> KPIReports { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}