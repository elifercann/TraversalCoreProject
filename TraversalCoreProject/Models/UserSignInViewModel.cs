using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
