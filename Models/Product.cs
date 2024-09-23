using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Mobile_Shopping_Project.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        [ForeignKey("cart")]
        public int? cid { get; set; }
        //Navigation Property
        public List<User_Product> users { get; set; }
        public Cart cart { get; set; }
    }
}
