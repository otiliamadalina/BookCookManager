using System;
using System.Collections.Generic;
using BookCookManager.Domain.Entities.BaseEntities;
using BookCookManager.Domain.Entities.Ingredient;

namespace BookCookManager.Domain.Entities.Recipe
{
    public class NewRecipeDto : BaseEntity
    {
        public string RecipeTitle { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeInstructions { get; set; }
        public DateTime RecipeAdded { get; set; }
        public BookCookManager.Domain.Entities.User.User CreatedByUser { get; set; }


    }
}
