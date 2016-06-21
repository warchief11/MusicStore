using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class Address
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 3)]
        public string AddressLine1 { get; set; }

        [StringLength(70, MinimumLength = 3)]
        public string AddressLine2 { get; set; }

        [StringLength(70, MinimumLength = 3)]
        public string AddressLine3 { get; set; }

        [Required]
        [StringLength(40)]
        public string City { get; set; }

        [Required]
        [StringLength(40)]
        public string State { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [StringLength(10, MinimumLength = 5)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(40)]
        public string Country { get; set; }

        [Required]
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}