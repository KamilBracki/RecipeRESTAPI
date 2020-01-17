using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.DBModel;
using RecipeAPI.Model.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI.Controllers
{





    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {

        private readonly RecipeDataContext _context;

        public IngredientController(RecipeDataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientDTO>>> GetIngredients()
        {

            return await _context.Ingredients.Select(x => new IngredientDTO
            {
                Id = x.Id,
                Name = x.Name,
                Proteins = x.Proteins,
                Carbohydrates = x.Carbohydrates,
                Fat = x.Fat

            }).ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientDTO>> GetIngredientById(int id)
        {
            var IngredientDTO = await _context.Ingredients.Where(x => x.Id == id).Select(x => new IngredientDTO
            {

                Id = x.Id,
                Name = x.Name,
                Proteins = x.Proteins,
                Carbohydrates = x.Carbohydrates,
                Fat = x.Fat
            }).FirstOrDefaultAsync();

            if (IngredientDTO == null)
            {
                return NotFound();
            }


            return IngredientDTO;
        }

        [HttpGet("{name:alpha}")]
        public async Task<ActionResult<IngredientDTO>> GetIngredientByName(string name)
        {
            var IngredientDTO = await _context.Ingredients.Where(x => x.Name == name).Select(x => new IngredientDTO
            {

                Id = x.Id,
                Name = x.Name,
                Proteins = x.Proteins,
                Carbohydrates = x.Carbohydrates,
                Fat = x.Fat

            }).FirstOrDefaultAsync();

            if (IngredientDTO == null)
            {
                return NotFound();
            }


            return IngredientDTO;
        }

        
        [HttpPost]
        public async void Post([FromBody] IngredientDTO ingredient)
        {
            var NewIngredient = new Ingredient
            {
                Name = ingredient.Name,
                Proteins = ingredient.Proteins,
                Carbohydrates = ingredient.Carbohydrates,
                Fat = ingredient.Fat
            };

            using(var ctxt = new RecipeDataContext()) 
            {
                ctxt.Ingredients.Add(NewIngredient);
                await ctxt.SaveChangesAsync();
            }

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngredient(int id, [FromBody] Ingredient ingredient)
        {
            if (id != ingredient.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientExists(id))
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


        [HttpDelete("deleteId/{id:int}")]
        public async Task<IActionResult> DeleteIngredientById(int id)
        {

            var Ingredient = _context.Ingredients.Find(id);

            using( var context = new RecipeDataContext())
            {
                if(Ingredient == null)
                {
                    return NotFound();
                };
            
                context.Ingredients.Remove(Ingredient);
                await context.SaveChangesAsync();
            };
            return NoContent();
        }
        
        [HttpDelete("deleteName/{name:alpha}")]
        public async Task<IActionResult> DeleteIngredientByName(string name)
        {

            using (var context = new RecipeDataContext())
            {
                var Ingredient = context.Ingredients.Where(x => x.Name == name).Select(x => new Ingredient
                {
                    Id = x.Id,
                    Name = x.Name,
                    Proteins = x.Proteins,
                    Carbohydrates = x.Carbohydrates,
                    Fat = x.Fat
                }).FirstOrDefault();

                if (Ingredient == null)
                {
                    return NotFound();
                };

                context.Ingredients.Remove(Ingredient);
                await context.SaveChangesAsync();
            };
            return NoContent();
        }
        private bool IngredientExists(int id)
        {
            return _context.Ingredients.Any(e => e.Id == id);
        }
    }
}
