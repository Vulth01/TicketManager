﻿using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide username")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
        public string? Password { get; set; }
    }
}
