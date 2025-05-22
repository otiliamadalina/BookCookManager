using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BookCookManager.Domain.Entities.BaseEntities;

namespace BookCookManager.Domain.Entities.User
{
    public class User : BaseEntity
    {
        [Required]
        [Display(Name = "User Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Username is not valid")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "User Email")]
        [StringLength(50, MinimumLength = 11, ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "User Password")]
        [StringLength(250, MinimumLength = 8, ErrorMessage = "Password is not valid")]
        public string Password { get; set; }
        [Display(Name = "RegisterDateTime")]

        public DateTime ReggisterDateTime { get; set; }
    }
}
