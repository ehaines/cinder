using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using sketchmates.Infrastructure.Identity.Models;
using System.Threading.Tasks;

namespace sketchmates.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<ApplicationRole> roleManager)
        {
            //Seed Roles
            if (!await roleManager.Roles.AnyAsync() && !await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new ApplicationRole("Admin"));
        }
    }
}
