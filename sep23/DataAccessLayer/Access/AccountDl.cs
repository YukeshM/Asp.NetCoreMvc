using DataAccessLayer.Models;

using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;


namespace DataAccessLayer.Access
{
    public class AccountDl
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly SignInManager<IdentityUser> _signInManager;

        //public AccountDl(UserManager<IdentityUser> userManager,
        //                        SignInManager<IdentityUser> signInManager)
        //{
        //    this._userManager = userManager;
        //    this._signInManager = signInManager;
        //}

        public AccountDl(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }


        public async Task<IdentityResult> CreateUser(RegistrationModel model)
        {

            var userDetails = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(userDetails, model.Password);
            return result;

        }
    }
}
