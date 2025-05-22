using System;
using System.Collections.Generic;
using System.Text;
using BookCookManager.Domain.Entities.BaseEntities;

namespace BookCookManager.Domain.Entities.Ingredient
{
    public class IngredientDto : BaseEntity
    {
        public string IngredientName{ get; set; }
        public string Quantity { get; set; }
    }
}
