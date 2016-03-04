using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCustomersMVC.ViewModels
{
    public class CreateCustomerVM
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Input username to proceed")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Input e-mail address to proceed")]
        public string Email { get; set; }

        [Display(Name = "I Accept Terms and conditions")]
        public bool AcceptTerms { get; set; }
    }
}
