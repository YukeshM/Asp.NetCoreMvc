using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTimeEntryWith3Tier.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<IdentityUser> _userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        UserManager<IdentityUser> userManager
                                        )
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.Role
                };

                IdentityResult identityResult = await _roleManager.CreateAsync(identityRole);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration");
                }

                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ListRole()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var result = await _roleManager.FindByIdAsync(id);
            ;

            if (result == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {id} cannot found";
                return View("NotFound");
            }

            var model = new EditRoleModel
            {
                Id = result.Id,
                RoleName = result.Name
            };

            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, result.Name))
                {
                    model.User.Add(user.UserName);
                }
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleModel model)
        {
            var result = await _roleManager.FindByIdAsync(model.Id);

            if (result == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {model.Id} cannot found";
                return View("NotFound");
            }
            else
            {
                result.Name = model.RoleName;
                var finalResult = await _roleManager.UpdateAsync(result);

                if (finalResult.Succeeded)
                {
                    return RedirectToAction("ListRole");
                }

                foreach (var error in finalResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);

            }


        }

        public IActionResult DeleteRole()
        {
            return View();
        }

        public async Task<IActionResult> EditUserInRole(string roleId)
        {
            ViewBag.Id = roleId;

            var roleDetails = await _roleManager.FindByIdAsync(roleId);

            if (roleDetails == null)
            {
                ViewBag.ErrorMessage = $"Role with id ={roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<EditUserRoleModel>();

            foreach (var user in _userManager.Users)
            {
                var userRoleViewModel = new EditUserRoleModel()
                {
                    Id = user.Id,
                    Name = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, roleDetails.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }
                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserInRole(List<EditUserRoleModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {roleId} not found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].Id);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(
                    user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(
                    user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new
                        {
                            Id = roleId
                        });

                }
            }

            return RedirectToAction("EditRole", new
            {
                Id = roleId
            });

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
