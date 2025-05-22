#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace e_ticaret_sitesi.Areas.Identity.Pages.Account.Manage
{
    public class Disable2faModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Disable2faModel> _logger;

        public Disable2faModel(
            UserManager<IdentityUser> userManager,
            ILogger<Disable2faModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Kullanıcı '{_userManager.GetUserId(User)}' yüklenemedi.");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                throw new InvalidOperationException($"Kullanıcı için 2FA devre dışı bırakılamaz çünkü şu anda etkin değil.");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Kullanıcı '{_userManager.GetUserId(User)}' yüklenemedi.");
            }

            var disable2faResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
            if (!disable2faResult.Succeeded)
            {
                throw new InvalidOperationException($"2FA'yı devre dışı bırakırken beklenmedik bir hata oluştu.");
            }

            _logger.LogInformation("Kullanıcı ID '{UserId}' 2FA'yı devre dışı bıraktı.", _userManager.GetUserId(User));
            StatusMessage = "2FA devre dışı bırakıldı. Bir kimlik doğrulayıcı uygulaması kurduğunuzda 2FA'yı tekrar etkinleştirebilirsiniz.";
            return RedirectToPage("./TwoFactorAuthentication");
        }
    }
}
