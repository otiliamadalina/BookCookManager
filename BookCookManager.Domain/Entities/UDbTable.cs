using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCookManager.Domain.Entities
{
    class UDbTable
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Username can not be longer than 30 characters.")]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
