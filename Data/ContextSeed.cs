using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

public static class ContextSeed
{
    public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole(Webdevelopment_Project.Enums.Roles.Moderator.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Webdevelopment_Project.Enums.Roles.Hulpverlener.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Webdevelopment_Project.Enums.Roles.Client.ToString()));
    }
}