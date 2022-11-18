using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GDIHackathonRecipeApp.Data;
using GDIHackathonRecipeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GDIHackathonRecipeApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ILogger<RecipeController> _logger;

        private ApplicationDbContext _dbContext;

        public RecipeController(ILogger<RecipeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        //view homepage (view buttons that will enable recipes to be shown)
        // GET: /<controller>/
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        // get recipe id
        [HttpGet("{id}")]
        public Recipe? GetRecipeById(int id)
        {
            return _dbContext.Recipes
                .Include(p => p.Notes)
                .AsNoTracking()
                .SingleOrDefault(p => p.Id == id);
        }

        // save a new recipe
        [HttpPost]
        public Recipe Save(Recipe newRecipe)
        {
            _dbContext.Recipes.Add(newRecipe);
            _dbContext.SaveChanges();

            return newRecipe;
        }


        // get note id
        public Note? GetNoteById(int id)
        {
            return _dbContext.Notes
                .AsNoTracking()
                .SingleOrDefault(p => p.Id == id);
        }


        //save a new note
        public Note Save(Note newNote)
        {
            _dbContext.Notes.Add(newNote);
            _dbContext.SaveChanges();

            return newNote;
        }

        //edit an existing note
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NoteContents,CreationDate,RecipeId")] Note note)
        {
            if (id != note.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(note);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoteExists(note.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(note);
        }

        private bool NoteExists(int id)
        {
            return _dbContext.Notes.Any(e => e.Id == id);
        }

        private bool RecipeExists(int id)
        {
            return _dbContext.Recipes.Any(e => e.Id == id);
        }

        //delete recipe

        [HttpPost, ActionName("DeleteRecipe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRecipeConfirmed(int id)
        {
            var recipe = await _dbContext.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _dbContext.Recipes.Remove(recipe);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        //delete note

        [HttpPost, ActionName("DeleteNote")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteNoteConfirmed(int id)
        {
            var note = await _dbContext.Notes.FindAsync(id);
            if (note != null)
            {
                _dbContext.Notes.Remove(note);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}

