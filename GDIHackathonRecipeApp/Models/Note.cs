﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GDIHackathonRecipeApp.Models
{
	public class Note
	{
        public int Id { get; set; }

        [Required]
        public string NoteContents { get; set; }
        public DateTime CreationDate { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public Note()
        {
        }
    }
}

