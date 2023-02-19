using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Models
{
    public class UserChangePasswordViewModel
    {
        [Required, DataType(DataType.Password), Display(Name = "Please enter your current password")]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Please enter your new password")]
        public string NewPassword { get; set; }
    }
}
