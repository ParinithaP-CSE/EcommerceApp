using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePicURl { get; set; }
    }
}
