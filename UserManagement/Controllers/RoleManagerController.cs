using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Controllers
{
    public class RoleManagerController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleManagerController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }



        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string newRoleName)
        {
            if (newRoleName != null)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(newRoleName));
                if (result.Succeeded)
                {
                    TempData["message"] = "Add role successfully";
                }

            }
            else
            {
                TempData["message"] = "Please add role name";
            }

            return RedirectToAction("Index");
        }
    }
}
