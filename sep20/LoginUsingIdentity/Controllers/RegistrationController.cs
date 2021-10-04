using DNTCaptcha.Core;
using LoginUsingIdentity.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginUsingIdentity.Controllers
{
  public class RegistrationController : Controller
  {
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public RegistrationController(UserManager<IdentityUser> userManager,
                                  SignInManager<IdentityUser> signInManager)
    {
      this._userManager = userManager;
      this._signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(Registration model)
    {
      if (ModelState.IsValid)
      {
        var user = new IdentityUser { UserName = model.Email, Email = model.Email };
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
          await _signInManager.SignInAsync(user, isPersistent: false);
          return RedirectToAction("Create", "View");
        }

        foreach (var error in result.Errors)
        {
          ModelState.AddModelError(string.Empty, error.Description);
        }
      }

      return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> LogOut()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [ValidateDNTCaptcha(
        ErrorMessage = "Please Enter Valid Captcha",
        CaptchaGeneratorLanguage = Language.English,
        CaptchaGeneratorDisplayMode = DisplayMode.ShowDigits)]
    public async Task<IActionResult> Login(Login model)
    {
      if (ModelState.IsValid)
      {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password
            , model.RememberMe, false);

        if (result.Succeeded)
        {
          return RedirectToAction("Index", "View");
        }
        ModelState.AddModelError(string.Empty, "Invalid login details");
      }

      return View(model);
    }
  }
}
