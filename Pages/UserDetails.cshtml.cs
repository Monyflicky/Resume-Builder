using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesResume.Model;
using Newtonsoft.Json;

namespace RazorPagesResume.Pages
{
    public class UserDetailsModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        [BindProperty]
        public UserModel user {get; set;}

        public UserDetailsModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        
        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            TempData["user"] = JsonConvert.SerializeObject(user);
            return RedirectToPage("/Resume");
        }
    }
}
