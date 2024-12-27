using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public List<Category>Categories{ get; set; }= new ();
        public async Task OnGet()
        {
            
            await Task.Delay(5000);//adiciona um delay de 5 segundos no carregamento da tela tentando buscar algo
            for (var i = 0;i <= 100;i++)
            {
                Categories.Add(
                    new Category (
                    i,//id
                    $"Categoria{i}",//Title
                    i*18.95M));//Price
            }
        }
        public void OnPost()
        {

        }
    }

    public record Category(int Id,
    string Title,
    decimal Price)
    {
        
    }
}
