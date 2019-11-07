using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.DTO;

namespace RecipeAPI.Controllers
{


    


    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {

        private RecipeDataContext _context;

        public IngredientController(RecipeDataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientDTO>>> GetIngredients()
        {

            return await  _context.Ingredients.Select(x => new IngredientDTO
            {
                Id = x.Id,
                Name = x.Name,
                Proteins = x.Proteins,
                Carbohydrates = x.Carbohydrates,
                Fat = x.Fat

            }).ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
