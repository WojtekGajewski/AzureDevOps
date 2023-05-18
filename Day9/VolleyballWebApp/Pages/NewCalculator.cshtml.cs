using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VolleyballWebApp.Pages
{
    public class NewCalculatorModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        //        public int Number1 { get; set; } = 2; // STARTING VALUE 
        [BindProperty]
        public int Number2 { get; set; }
        [TempData]
        public int AdditionResult { get; set; }
        [TempData]
        public int SubstractionResult { get; set; }
        public void OnGet()
        {
        }
        public void OnPostAdd()
        {
            AdditionResult = Number1 + Number2;
        }
        public void OnPostSubstract()
        {
            SubstractionResult = Number1 - Number2;
        }
    }
}
