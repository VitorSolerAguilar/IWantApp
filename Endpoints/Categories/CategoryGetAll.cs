using IWantApp.Domain.Products;
using IWantApp.Infra.Data;

namespace IWantApp.Endpoints.Categories;

public class CategoryGetAll
{
    // Rota de category
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(AplicationDbContext context)
    {
        // Retorna todas as categorias
        var categories = context.Categories.ToList();
        var response = categories.Select(c => new CategoryResponse { Name = c.Name, Active = c.Active });

        return Results.Ok(response);
    }
}
