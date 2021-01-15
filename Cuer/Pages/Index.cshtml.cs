using System.ComponentModel.DataAnnotations;
using Cuer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cuer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CuerService _cuerService;
        public string SvgString { get; set; }
        
        [BindProperty]
        [MinLength(1)]
        [MaxLength(1000)]
        [Required]
        public string TextData { get; set; }
        
        public IndexModel(CuerService cuerService)
        {
            _cuerService = cuerService;
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(TextData))
            {
                SvgString = _cuerService.GenerateSvgString(TextData);
            }

            ModelState.Clear();
            return Page();
        }
    }
}