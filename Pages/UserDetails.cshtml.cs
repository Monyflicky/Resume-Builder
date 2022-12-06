using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesResume.Model;
using Newtonsoft.Json;

using Microsoft.EntityFrameworkCore;

namespace RazorPagesResume.Pages
{
    public class UserDetailsModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly UserContext _context;

        [BindProperty]
        public UserModel user {get; set;}

        public UserDetailsModel(ILogger<PrivacyModel> logger, UserContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            _context.users.Add(user);
            await _context.SaveChangesAsync();

            TempData["user"] = JsonConvert.SerializeObject(user);
            return RedirectToPage("/Resume");
        }
    }
}
