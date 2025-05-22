using System;
using System.Collections.Generic;
using System.Text;
using BookCookManager.Domain.Entities.Recipe;

namespace BookCookManager.BusinessLogic.Interface
{
    public interface IRecipeServices
    {
        //CRUD op
        void AddRecipe(NewRecipeDto recipe);
        void GetAllRecipes(NewRecipeDto recipe);
        void UpdateRecipe(NewRecipeDto recipe);
        void DeleteRecipe(NewRecipeDto recipe);
    }
}
