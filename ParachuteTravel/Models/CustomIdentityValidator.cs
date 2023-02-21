using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
            public override IdentityError PasswordTooShort(int length)
            {
                return new IdentityError()
                {
                    Code = "PasswordTooShort",
                    Description = $"Password must be Minimum {length} characters"
                };
            }
            public override IdentityError PasswordRequiresUpper()
            {
                return new IdentityError()
                {
                    Code = "PasswordRequiresUpper",
                    Description = "Password must contain at least 1 capital letter"
                };
            }
            public override IdentityError PasswordRequiresLower()
            {
                return new IdentityError()
                {
                    Code = "PasswordRequiresLower",
                    Description = "Password must contain at least 1 lowercase letter"
                };
            }
            public override IdentityError PasswordRequiresNonAlphanumeric()
            {
                return new IdentityError()
                {
                    Code = "PasswordRequiresNonAlphanumeric",
                    Description = "Password must contain at least 1 symbol"
                };
            }
     }

}

