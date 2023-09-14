using System.ComponentModel.DataAnnotations;

namespace ContactManagerWeb.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
    }
}
