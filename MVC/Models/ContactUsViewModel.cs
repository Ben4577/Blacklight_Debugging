using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackLight.Recruitment.MVC.Models
{
    public class ContactUsViewModel
    {
        [Required]

        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Message For He who Reclaims from Smaug")]
        public string MessageForHeWhoReclaimsFromSmaug { get; set; }

    }
}