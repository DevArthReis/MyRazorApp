using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CategoriesModel : PageModel
    {
        public List<Category>Categories{ get; set; }= new ();
        public void OnGet()
        {
            
            //await Task.Delay(5000);//adiciona um delay de 5 segundos no carregamento da tela tentando buscar algo
            for (var i = 0;i <= 100;i++)
            {
                Categories.Add(
                    new Category (
                    i,//id
                    $"Categoria{i}",//Title
                    i*18.95M));//Price
            }
        }
    
    }
    
}
public record Category(int Id,
    string Title,
    decimal Price);
