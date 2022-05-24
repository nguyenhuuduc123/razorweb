using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp_razor_09.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly MyBlogContext _context;

        public IndexModel(MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }
        public const int Item_per_page = 10;

        [BindProperty(SupportsGet = true, Name = "p")]

        public int CurrentPage {get;set;}
        public int CountPages {get;set;}


        public async Task OnGetAsync(string searchstring)
        {
          int total_article =  await _context.articles.CountAsync();
          CountPages = (int)Math.Ceiling((double)total_article/ Item_per_page);
          if(CurrentPage <1){
            CurrentPage = 1;
          }
          if(CurrentPage >CountPages){
            CurrentPage = CountPages; 
          }
            
         //   Article = await _context.articles.ToListAsync();
            var qr  = (from a in _context.articles 
                        orderby a.Created descending
                        select a).Skip((CurrentPage-1)*Item_per_page).Take(Item_per_page);
             
             if(!string.IsNullOrEmpty(searchstring)){
              Article = qr.Where(a => a.Title.Contains(searchstring)).ToList();;
            }
          else{
                Article = await qr.ToListAsync();
          }
        }
    }
}
