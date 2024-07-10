using Microsoft.AspNetCore.Identity;
using ProfessorOfTheYear.Data;

namespace ProfessorOfTheYear.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Ошибка: Невозможно загрузить пользователя с ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
