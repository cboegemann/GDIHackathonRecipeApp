using System;
namespace GDIHackathonRecipeApp.Models
{
	public class Note
	{
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public Note()
        {
        }
    }
}

