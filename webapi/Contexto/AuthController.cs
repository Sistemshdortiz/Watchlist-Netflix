using Microsoft.AspNetCore.Mvc;
using webapi.ViewModels;

namespace webapi.Contexto
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User { UserName = model.Mail, Email = model.Mail };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Aquí puedes agregar la lógica para generar el token, por ejemplo, usando Identity
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);

                // Devolver el token u otra respuesta según tus necesidades
                return Ok(new { Token = token });
            }

            return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                // Aquí puedes agregar la lógica para generar el token después de iniciar sesión
                var user = await userManager.FindByEmailAsync(model.Email);
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);

                // Devolver el token u otra respuesta según tus necesidades
                return Ok(new { Token = token });
            }

            return BadRequest(new { Error = "Invalid login attempt" });
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return Ok(new { Message = "Logout successful" });
        }
    }
}
