using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp_razor_09.Pages_Blog
{
    public class CreateModel : PageModel
    {
        private readonly MyBlogContext _context;

        public CreateModel(MyBlogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) // nếu tất cả dữ liệu phù hợp thì xử lý tiếp
            {
                return Page();
            }

            _context.articles.Add(Article);
            await _context.SaveChangesAsync();// đồng bộ về cơ sở dữ liệu

            return RedirectToPage("./Index"); // chuyển hướng đến trang chủ
        }
    }
}
