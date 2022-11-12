using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }   
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; } 
    }
}
