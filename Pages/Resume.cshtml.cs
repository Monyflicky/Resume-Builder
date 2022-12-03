using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using RazorPagesResume.Model;
using Newtonsoft.Json;

namespace RazorPagesResume.Pages
{
    public class ResumeModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public UserModel user {get; set;}

        public ResumeModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
             user =  JsonConvert.DeserializeObject<UserModel>(TempData["user"]?.ToString());
        }
    }
    
}