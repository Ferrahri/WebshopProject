using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            //Set value in Session object.
            //HttpContext.Session.SetString("cart", "empty");
        }
    }

}