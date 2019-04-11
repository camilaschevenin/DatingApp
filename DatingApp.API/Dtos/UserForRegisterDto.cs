using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 8")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
