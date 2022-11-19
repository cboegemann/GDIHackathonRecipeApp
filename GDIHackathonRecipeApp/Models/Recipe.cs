using System;
using System.ComponentModel.DataAnnotations;

namespace GDIHackathonRecipeApp.Models
{
	public class Recipe
	{
		public int Id { get; set; }

        //[Required]
        //public string? Name { get; set; }

        //public int CookbookId { get; set; }
        //public Cookbook? Cookbook { get; set; }

        public ICollection<Cookbook>? Cookbooks { get; set; }

        public ICollection<Note>? Notes { get; set; }

        public ICollection<DietaryRestriction>? DietaryRestrictions { get; set; }

	}
}

