using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace asp_razor_09.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyBlogContext myblog;

        public IndexModel(ILogger<IndexModel> logger,MyBlogContext _myblog)
        {
            _logger = logger;
            myblog = _myblog;
        }

        public void OnGet()
        {
            var posts = (from b in myblog.articles
                        orderby b.Created descending
                        select b).ToList();
            ViewData["posts"] = posts;

        }
    }
}
