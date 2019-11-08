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
    public class TagController : ControllerBase
    {
        private readonly RecipeDataContext _context;
        public TagController(RecipeDataContext context)
        {
            _context = context;
        }

        // GET api/Tag
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagDTO>>> GetTags()
        {

            return await _context.Tags.Select(x => new TagDTO
            {
                Id = x.Id,
                Name = x.Name

            }).ToListAsync();
        }

        // GET api/Tag/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TagDTO>> GetTagById(int id)
        {
            var TagDTO = await _context.Tags.Where(x => x.Id == id).Select(x => new TagDTO
            {

                Id = x.Id,
                Name = x.Name
            }).FirstOrDefaultAsync();

            if (TagDTO == null)
            {
                return NotFound();
            }


            return TagDTO;
        }

        [HttpGet("{name:alpha}")]
        public async Task<ActionResult<TagDTO>> GetTagByName(string name)
        {
            var TagDTO = await _context.Tags.Where(x => x.Name == name).Select(x => new TagDTO
            {

                Id = x.Id,
                Name = x.Name
            }).FirstOrDefaultAsync();

            if (TagDTO == null)
            {
                return NotFound();
            }


            return TagDTO;
        }



    }
}
