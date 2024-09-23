using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Mobile_Shopping_Project.Models
{
    public class User_Product
    {
        [ForeignKey("user")]
        public int userid { get; set; }
        [ForeignKey("product")]
        public int productid { get; set; }
        public User user { get; set; }
        public Product product { get; set; }
    }
}
