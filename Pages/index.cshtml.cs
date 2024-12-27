using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public List<Category>Categories{ get; set; }= new ();
        public async Task OnGet()
        {
            
            await Task.Delay(5000);
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

    public record Category(int id,
    string title,
    decimal price)
    {
        
    }
}
