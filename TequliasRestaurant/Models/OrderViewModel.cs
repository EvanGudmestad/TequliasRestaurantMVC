namespace TequliasRestaurant.Models
{
    public class OrderViewModel
    {
        public decimal TotalAmount { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
