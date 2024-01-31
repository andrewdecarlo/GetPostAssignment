using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GetPostUI.Models;

namespace GetPostUI.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //Make person info properties available for GET
        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new PersonInfo();

        public void OnGet()
        {
            _logger.LogInformation("Person Index OnGet()");
        }

        public void OnPost()
        {
            _logger.LogInformation("Person Index OnPost()");
        }
    }
}
