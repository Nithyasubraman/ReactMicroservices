using Microsoft.AspNetCore.Mvc;
using Trainer.Data;
using Microsoft.EntityFrameworkCore;

namespace Trainer.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainerController : ControllerBase
    {
        private readonly ApiDbContext _context;

        private int id;

        public TrainerController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetTrainer")]
        public ActionResult<IEnumerable<Trainer>> Get()
        {
            return _context.Trainers.ToList();
        }
    }
}