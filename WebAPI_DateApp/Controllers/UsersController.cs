using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_DateApp.Data;
using WebAPI_DateApp.Entities;

namespace WebAPI_DateApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext context { get; }
        public UsersController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await context.Users.FirstOrDefaultAsync(parameter=>parameter.Id==id);
        }

    }
}