using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using ProfessorOfTheYear.Data;

namespace ProfessorOfTheYear.Components.Account
{
    // Remove the "else if (EmailSender is IdentityNoOpEmailSender)" block from RegisterConfirmation.razor after updating with a real implementation.
    internal sealed class IdentityNoOpEmailSender : IEmailSender<ApplicationUser>
    {
        private readonly IEmailSender emailSender = new NoOpEmailSender();

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            emailSender.SendEmailAsync(email, "Подтвердите адрес электронной почты", $"<a href='{confirmationLink}'>Нажмите здесь</a>, чтобы подтвердить акаунт.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            emailSender.SendEmailAsync(email, "Сбросте пароль", $"<a href='{resetLink}'>Нажмите здесь</a>, чтобы сбросить пароль.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            emailSender.SendEmailAsync(email, "Сбросте пароль", $"Сбросте пароль используя следующий код: {resetCode}");
    }
}
