using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter re-password")]
        [Compare("Password", ErrorMessage = "Passwords do not match. Your password must be the same as the Password field!")]
        public string ConfirmPassword { get; set; }
    }
}
