using System;
using System.ComponentModel.DataAnnotations;

namespace GDIHackathonRecipeApp.Models
{
	public class Note
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Your note is empty!")]
        public string? NoteContents { get; set; }
        public DateTime CreationDate { get; set; }

        [Required]
        public int RecipeId { get; set; }
        //public Recipe? Recipe { get; set; }

    }
}

