using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GetPostUI.Models;

namespace GetPostUI.Pages.Person
{
    public class AddInfoModel : PageModel
    {
        private readonly ILogger<AddInfoModel> _logger;

        public AddInfoModel(ILogger<AddInfoModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new PersonInfo();
        public void OnGet()
        {
            _logger.LogInformation("Person AddInfo OnGet()");
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Person AddInfo OnPost()");

            if (ModelState.IsValid)
            {
                return RedirectToPage("Index", CurrentPerson);
            }

            return Page();
        }
    }
}
