using Microsoft.AspNetCore.Mvc;
using VotingApp.Models;

// --- THIS IS THE CONTROLLER ---
// It acts as the brain, managing the flow between the User and the Data.
public class VoteController : Controller
{
    // --- THIS IS AN ACTION (GET) ---
    // It handles the initial request when the user visits /Vote/Index
    [HttpGet]
    public IActionResult Index()
    {
        // This tells the Razor View Engine to look for Views/Vote/Index.cshtml
        return View();
    }

    // --- THIS IS AN ACTION (POST) ---
    // It handles the form submission when the user clicks the button.
    [HttpPost]
    public IActionResult CheckEligibility(string userName, int userAge)
    {
        // Business Logic: The controller decides the outcome
        bool eligibility = userAge >= 18;

        // Creating the Model to hold our data
        User person = new User
        {
            Name = userName,
            Age = userAge,
            CanVote = eligibility
        };

        // This sends the Model data to the 'Result' View
        return View("Result", person);
    }
}
