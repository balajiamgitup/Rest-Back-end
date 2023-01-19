using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace restApi2.model
{
    public class Order
    {
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderID { get; set; }
        public decimal GTotal { get; set; }
        public string ItemId { get; set; }
        public int quantity { get; set; }

    //    public ICollection<Item> items { get; set; }

    }
}
