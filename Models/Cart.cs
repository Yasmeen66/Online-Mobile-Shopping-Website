using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Mobile_Shopping_Project.Models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="*")]
        public int creditcardnumber { get; set; }
        public string address { get; set; }
        public List<Product> products { get; set; }

    }
}
