using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Name field cannot be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password field cannot be empty")]

        public string Password { get; set; }
    }
}
