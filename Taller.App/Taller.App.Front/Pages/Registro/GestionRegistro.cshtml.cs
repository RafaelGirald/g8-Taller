using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.App.Front.Pages
{
    public class GestionRegistroModel : PageModel
    {
        public List <string> departamentos = new List<string>(){
            "Antioquia","Quindio","Cundinamarca","Tolima" 
        };
        public void OnGet()
        {
        }
    }
}
