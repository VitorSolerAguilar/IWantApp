namespace IWantApp.Domain.Products;

public class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool HasStock { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    // Saber se a categoria esta ativa
    public bool Active { get; set; } = true;
}
