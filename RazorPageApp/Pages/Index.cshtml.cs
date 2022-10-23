using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApp.Infrastructure;
using RazorPageApp.Models;

namespace RazorPageApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorAppContext _appContext;
        public List<Article> Articles { get; set; }

        public IndexModel(RazorAppContext appContext)
        {
            _appContext = appContext;
        }

        public void OnGet()
        {
            Articles = _appContext.Articles.OrderByDescending(x => x.Id).ToList();
        }
    }
}