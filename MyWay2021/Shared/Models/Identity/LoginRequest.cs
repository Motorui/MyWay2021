﻿using System.ComponentModel.DataAnnotations;

namespace MyWay2021.Shared.Models.Identity
{
    public class LoginRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
