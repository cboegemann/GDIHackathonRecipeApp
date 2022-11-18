using System;
using System.ComponentModel.DataAnnotations;

namespace GDIHackathonRecipeApp.Models
{
	public class DietaryRestriction
	{
        public int Id { get; set; }

        [Required]
        public string? Restriction { get; set; }

        [Required]
        public int RecipeId { get; set; }
        //public Recipe? Recipe { get; set; }

    }
}

