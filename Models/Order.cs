public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } // Navigation property
    public int ProductId { get; set; }
    public Product Product { get; set; } // Navigation property
    public DateTime OrderDate { get; set; }
}