namespace Eshop.Core.Application.Dto
{
    public class CartItemDto
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double SubTotal { get; set; }
    }
}
