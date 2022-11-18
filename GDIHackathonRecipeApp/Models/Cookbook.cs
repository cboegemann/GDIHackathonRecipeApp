using System;
using System.ComponentModel.DataAnnotations;

namespace GDIHackathonRecipeApp.Models
{
	public class Cookbook
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Your cookbook must have a name.")]
        public string? Name { get; set; }

		public string? Description { get; set; }

		public ICollection<Recipe>? Recipes { get; set; }
	}
}

