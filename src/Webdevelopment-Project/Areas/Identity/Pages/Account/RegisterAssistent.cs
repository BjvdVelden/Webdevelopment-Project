using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Webdevelopment_Project.Models;
using Webdevelopment_Project.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace Webdevelopment_Project.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel1 : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public RegisterModel1(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
             [Required]
            [Display(Name = "Voornaam")]
            [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Gebruik alleen letters a.u.b.")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} moet ten minste {2} karakters en max {1} karakters hebben.")]
            public string Voornaam { get; set; }
            
            [Required]
            [Display(Name = "Achternaam")]
            [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Gebruik alleen letters a.u.b.")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} moet ten minste {2} karakters en max {1} karakters hebben.")]
            public string Achternaam { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "GeboorteDatum")]
            public DateTime Geboortedatum { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [EmailAddress]
            [Display(Name = "Email hulpverlener")]
            public string EmailHulpverlener { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "De  {0} moet ten minste {2} en max {1} karakters lang zijn.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Wachtwoord")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Bevestig wachtwoord")]
            [Compare("Password", ErrorMessage = "De wachtwoorden zijn niet gelijk.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
    
            if (ModelState.IsValid)
            {
                
                var koppelingDB = new assistentHulpverlenerKoppel {mailHulpverlener = Input.EmailHulpverlener, mailAssistent= Input.Email};
                _context.Add(koppelingDB);
                _context.SaveChanges();


                var user = new ApplicationUser {  UserName = Input.Email, Email = Input.Email, Voornaam = Input.Voornaam, Achternaam = Input.Achternaam, GeboorteDatum = Input.Geboortedatum, HulpverlenerEmail = Input.EmailHulpverlener };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {   
                    await _userManager.AddToRoleAsync(user, "Assistent");
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Bevestig uw account door <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>hier te klikken</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        // await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}

