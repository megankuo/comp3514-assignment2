using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Area of Specialization")]
        public string Specialization { get; set; }
        [Required]
        [Display(Name = "City of Residence")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Province of Residence")]
        public string Province { get; set; }
        [Required]
        public string Employer { get; set; }
    }
}