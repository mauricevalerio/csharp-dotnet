using kanban_web_api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace kanban_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KanbanController(DataContext context) : ControllerBase
    {
        private readonly DataContext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<GetKanbanDto>>> GetAllBoards()
        {
            var dbBoards = await _context.Boards
            .Include(c => c.Columns)
            .ToListAsync();

            return Ok(dbBoards);
        }
    }
}