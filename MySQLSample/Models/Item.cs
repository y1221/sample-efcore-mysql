using System.ComponentModel.DataAnnotations;

namespace MySQLSample.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "商品名")]
        public string Name { get; set; } = default!;

        [Display(Name = "価格")]
        public int Price { get; set; }
    }
}
