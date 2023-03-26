﻿using System.ComponentModel.DataAnnotations;

namespace DepremBilgiPlatformApp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string password { get; set; }
    }
}
