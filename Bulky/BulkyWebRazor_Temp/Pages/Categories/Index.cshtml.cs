using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Category> categoryList { get; set; }
        public IndexModel(ApplicationDbContext context) 
        {
            _context = context;
        }
        public void OnGet()
        {
            categoryList = _context.Categories.ToList();
        }
    }
}
