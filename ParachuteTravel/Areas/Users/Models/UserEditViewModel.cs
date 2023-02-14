using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Users.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string UserSurname { get; set; }      
        public string UserImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserMailAdress{ get; set; }
    }
}
