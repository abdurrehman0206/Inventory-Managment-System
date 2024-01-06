

namespace Project.Models
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedToInventoryDate { get; set; }
    }
}
