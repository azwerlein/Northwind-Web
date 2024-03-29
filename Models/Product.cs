using Microsoft.EntityFrameworkCore;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    [Precision(18, 2)]
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public short UnitsOnOrder { get; set; }
    public short ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public int CategoryId { get; set; }
    public ICollection<Category> Categories { get; set; }
}