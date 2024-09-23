using System.ComponentModel.DataAnnotations;

namespace Online_Mobile_Shopping_Project.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "*")]
        //  [RegularExpression("(^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$)", ErrorMessage = "Password must be Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string password { get; set; }
        public string message { get; set; } = "";
    }
}
