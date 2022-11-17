using System;
namespace GDIHackathonRecipeApp.Models
{
	public class Recipe
	{
		public int Id { get; set; }

		public ICollection<Note>? Notes { get; set; }
	}
}

