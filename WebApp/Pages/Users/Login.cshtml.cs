
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public string Msg { get; set; }   

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
