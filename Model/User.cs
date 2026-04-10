using System.ComponentModel.DataAnnotations;

namespace medicore360m1.Model
{
    public class User
    {
        //(UserID, Name, Role, Email, Phone
        [Key]
        public int UserId{ get; set; }
        public string Name{ get; set; }
        public string Role {  get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }

    }
}
