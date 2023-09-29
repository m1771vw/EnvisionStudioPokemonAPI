using EnvisionStudioPokemonAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class SignupModel : PageModel
    {
        private readonly UserService _userService;

        public SignupModel(UserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                bool userAdded = _userService.AddUser(Username, Password);

                if (userAdded)
                {
                    return RedirectToPage("/Login");
                }
                else
                {
                    ModelState.AddModelError("", "Username is already taken.");
                }
            }

            return Page();
        }
    }
}
