using System.Collections.Generic;
using System.Web.Mvc;

namespace BookCookManager.Web.Models
{
    public class UserData 
    {
       public string Username { get; set; }
        public List<string> Recipes { get; set; }
    }
}