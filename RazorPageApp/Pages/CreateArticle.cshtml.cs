using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApp.Infrastructure;
using RazorPageApp.Models;

namespace RazorPageApp.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly RazorAppContext _context;

        [BindProperty] public CreateArticle CreateArticle { get; set; }

        public CreateArticleModel(RazorAppContext context)
        {
            this._context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var newArticle = new Article(
                    CreateArticle.Title, CreateArticle.Picture,
                    CreateArticle.PictureAlt, CreateArticle.PictureTitle,
                    CreateArticle.ShortDescription, CreateArticle.Body
                );

                _context.Articles.Add(newArticle);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                TempData["error"] = "ریدی :)";
                return Page();
            }
        }
    }
}