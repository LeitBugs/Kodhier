﻿using System.ComponentModel.DataAnnotations;

namespace Kodhier.ViewModels.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool EmailSendUpdates { get; set; }
        public bool EmailSendPromotional { get; set; }
    }
}
