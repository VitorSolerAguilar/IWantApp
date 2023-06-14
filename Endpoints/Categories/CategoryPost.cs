using IWantApp.Infra.Data;

namespace IWantApp.Endpoints.Categories;

public class CategoryPost
{
    // Rota de category
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    // Status code
    public static IResult Action(CategoryRequest categoryRequest, AplicationDbContext context)
    {
        return Results.Ok("Ok");
    }
}
