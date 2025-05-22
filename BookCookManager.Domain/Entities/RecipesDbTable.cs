using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookCookManager.Domain.Entities.BaseEntities;

namespace BookCookManager.Domain.Entities
{
    public class RecipesDbTable : BaseEntity
    {
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Membership Name is not valid")]
        public string RecipeTitle { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string RecipeDescription { get; set; }

        [Required]
        [Display(Name = "Instructions")]
        public string RecipeInstructions { get; set; }

        [Required]
        [Display(Name = "Created by User")]
        public BookCookManager.Domain.Entities.User.User CreatedByUser { get; set; }
    }
}
