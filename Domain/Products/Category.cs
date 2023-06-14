namespace IWantApp.Domain.Products;

public class Category : Entity
{
    public string Name { get; set; }

    // Saber se a categoria esta ativa
    public bool Active { get; set; } = true;
}
