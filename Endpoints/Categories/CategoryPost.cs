using IWantApp.Domain.Products;
using IWantApp.Infra.Data;

namespace IWantApp.Endpoints.Categories;

public class CategoryPost
{
    // Rota de category
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, AplicationDbContext context)
    {
        var category = new Category(categoryRequest.Name)
        {
            CraetedBy = "teste",
            CreatedOn = DateTime.Now,
            EditedBy = "testes",
            EditedOn = DateTime.Now,
        };

        if (!category.IsValid)
        {
            return Results.BadRequest(category.Notifications);
        }
        context.Categories.Add(category);
        context.SaveChanges();

        return Results.Created("/categories/" + category.Id, category.Id);
    }
}
