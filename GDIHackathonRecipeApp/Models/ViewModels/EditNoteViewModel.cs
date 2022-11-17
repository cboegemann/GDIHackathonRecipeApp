using System;
namespace GDIHackathonRecipeApp.Models.ViewModels
{
	public class EditNoteViewModel
	{
        public int Id { get; set; }
        public string NoteContents { get; set; }
        public DateTime CreationDate { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

	}
}

