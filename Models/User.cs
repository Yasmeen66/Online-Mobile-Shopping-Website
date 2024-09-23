using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Mobile_Shopping_Project.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(20, ErrorMessage = "Max Length is 20 Char !")]
        public string name { get; set; }
        public int age { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression("\"\\d{3}\\s?\\d{4}-?\\d{4}\"gm")]
        public int phonenumber { get; set; }

        [Required(ErrorMessage = "*")]
        public string country { get; set; }
        public string gender { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression("(^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$)", ErrorMessage = "Password must be Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string password { get; set; }

        [NotMapped]
        [Compare("password", ErrorMessage = "Password does not match !")]
        public string confirmpassword { get; set; }
        //Vavigation Property
        public List<User_Product> products { get; set; }
    }
}
