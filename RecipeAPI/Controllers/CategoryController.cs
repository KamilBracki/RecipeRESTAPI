using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly RecipeDataContext _context;
        public CategoryController(RecipeDataContext context)
        {
            _context = context;
        }

        // GET api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategorys()
        {

            return await _context.Categories.Select(x => new CategoryDTO
            {
                Id = x.Id,
                Name = x.Name

            }).ToListAsync();
        }

        // GET api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryById(int id)
        {
            var CategoryDTO = await _context.Categories.Where(x => x.Id == id).Select(x => new CategoryDTO
            {

                Id = x.Id,
                Name = x.Name
            }).FirstOrDefaultAsync();

            if (CategoryDTO == null)
            {
                return NotFound();
            }


            return CategoryDTO;
        }

        [HttpGet("{name:alpha}")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryByName(string name)
        {
            var CategoryDTO = await _context.Categories.Where(x => x.Name == name).Select(x => new CategoryDTO
            {

                Id = x.Id,
                Name = x.Name
            }).FirstOrDefaultAsync();

            if (CategoryDTO == null)
            {
                return NotFound();
            }


            return CategoryDTO;
        }



    }



}
