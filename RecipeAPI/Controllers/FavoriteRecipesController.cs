using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.Model;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteRecipesController : ControllerBase
    {
        private readonly RecipeDataContext _context;

        public FavoriteRecipesController(RecipeDataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteRecipe>>> GetFavoriteRecipes()
        {
            return await _context.FavoriteRecipes.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteRecipe>> GetFavoriteRecipe(int id)
        {
            var favoriteRecipe = await _context.FavoriteRecipes.FindAsync(id);

            if (favoriteRecipe == null)
            {
                return NotFound();
            }

            return favoriteRecipe;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteRecipe(int id, FavoriteRecipe favoriteRecipe)
        {
            if (id != favoriteRecipe.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteRecipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteRecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<FavoriteRecipe>> PostFavoriteRecipe(FavoriteRecipe favoriteRecipe)
        {
            _context.FavoriteRecipes.Add(favoriteRecipe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteRecipe", new { id = favoriteRecipe.Id }, favoriteRecipe);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<FavoriteRecipe>> DeleteFavoriteRecipe(int id)
        {
            var favoriteRecipe = await _context.FavoriteRecipes.FindAsync(id);
            if (favoriteRecipe == null)
            {
                return NotFound();
            }

            _context.FavoriteRecipes.Remove(favoriteRecipe);
            await _context.SaveChangesAsync();

            return favoriteRecipe;
        }

        private bool FavoriteRecipeExists(int id)
        {
            return _context.FavoriteRecipes.Any(e => e.Id == id);
        }
    }
}
