﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationApi.ViewModel.Account
{
     public class LoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
