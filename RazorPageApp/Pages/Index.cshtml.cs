using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public RedirectToPageResult OnGetLoad()
        {
           return RedirectToPage("./Privacy");
        }
    }
}