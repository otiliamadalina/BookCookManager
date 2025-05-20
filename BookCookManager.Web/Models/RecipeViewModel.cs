using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCookManager.Web.Models
{
    public class RecipeViewModel
    {
        public int Id { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeIngredients { get; set; }
        public RecipeStatus Status { get; set; }

    }
}