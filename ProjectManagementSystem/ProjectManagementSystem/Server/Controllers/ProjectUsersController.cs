using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Server.Data;
using ProjectManagementSystem.Shared;

namespace ProjectManagementSystem.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProjectUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProjectUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectUser>>> GetProjectUser()
        {
            return await _context.ProjectUser.ToListAsync();
        }

        // GET: api/ProjectUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectUser>> GetProjectUser(Guid id)
        {
            var projectUser = await _context.ProjectUser.FindAsync(id);

            if (projectUser == null)
            {
                return NotFound();
            }

            return projectUser;
        }

        // PUT: api/ProjectUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectUser(Guid id, ProjectUser projectUser)
        {
            if (id != projectUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(projectUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectUserExists(id))
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

        // POST: api/ProjectUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProjectUser>> PostProjectUser(ProjectUser projectUser)
        {
            _context.ProjectUser.Add(projectUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjectUser", new { id = projectUser.Id }, projectUser);
        }

        // DELETE: api/ProjectUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectUser(Guid id)
        {
            var projectUser = await _context.ProjectUser.FindAsync(id);
            if (projectUser == null)
            {
                return NotFound();
            }

            _context.ProjectUser.Remove(projectUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectUserExists(Guid id)
        {
            return _context.ProjectUser.Any(e => e.Id == id);
        }
    }
}
