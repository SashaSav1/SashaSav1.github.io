using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using GODDAMN.Data;
using GODDAMN.Models;

namespace GODDAMN.Views.Home
{
    public class ShoesModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        [BindProperty]
        public Basket Basket { get; set; }
        public ShoesModel(ApplicationDbContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Baskets.Add(Basket);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
