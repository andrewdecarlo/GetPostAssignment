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

        //Make person info properties available for GET
        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new PersonInfo();
        public void OnGet()
        {
            _logger.LogInformation("Person AddInfo OnGet()");
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Person AddInfo OnPost()");

            //Check model state and redirect to index page if state is valid
            if (ModelState.IsValid)
            {
                return RedirectToPage("Index", CurrentPerson);
            }

            //Return to same page otherwise
            return Page();
        }
    }
}
