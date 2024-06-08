using System.ComponentModel.DataAnnotations;

namespace APBDzad6.DTOs.Request
{
    public class PatientCreateDTO
    {
        [Required]
        public int IdPatient { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
