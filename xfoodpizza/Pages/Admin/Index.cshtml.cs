using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using System.Collections.Generic;
using System.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;

namespace xfoodpizza.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public bool DisplayInvalideMessage = false;
        public bool isdeveloppementMode = false;

        public IndexModel(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;

            if (env.IsDevelopment())
            {
                isdeveloppementMode = true;
            }
        }

        public IConfiguration Configuration { get; }

        public IActionResult OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/Pizzas");
            }

            return Page();
        }

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin");
        }

        public async Task<IActionResult> OnPostAsync(string username, string password, string ReturnUrl)
        {
            var authsection = Configuration.GetSection("Auth");

            string adminLogin = authsection["AdminLogin"];
            string adminPassword = authsection["AdminPassword"];

            if ((username == adminLogin) && (password == adminPassword))
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                DisplayInvalideMessage = false;

                return Redirect(ReturnUrl == null ? "/Admin/Pizzas" : ReturnUrl);
            }

            DisplayInvalideMessage = true;

            return Page();
        }
    }
}