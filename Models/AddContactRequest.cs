using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Models
{
    public class AddContactRequest
    {
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public long Phone { get; set; }
        [MinLength(10, ErrorMessage = "Address should be minimum of 10 characters")]
        [MaxLength(200, ErrorMessage = "Address should be maximum of 200 characters")]
        public string Address { get; set; }
    }
}
