using System.Security.Claims;
using EnvisionStudioPokemonAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserService _userService;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(UserService userService, ILogger<LoginModel> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (_userService.IsValidUser(Username, Password))
            {
                var userId = _userService.GetUserId(Username); 

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Username),
                    new Claim(ClaimTypes.NameIdentifier, userId), 

                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToPage("/Index");
            }

            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
}
