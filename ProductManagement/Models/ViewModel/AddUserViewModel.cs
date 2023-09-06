﻿using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models.ViewModel
{
    public class AddUserViewModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string? ConfirmPassword { get; set; }
    }
}
