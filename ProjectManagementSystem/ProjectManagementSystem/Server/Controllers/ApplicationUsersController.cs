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
using ProjectManagementSystem.Server.Models;

namespace ProjectManagementSystem.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ApplicationUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ApplicationUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetApplicationUsers()
        {

            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers.ToListAsync();

            List<string> applicationUserEmails = new();
            
            foreach (var applicationUser in applicationUsers)
            {
                applicationUserEmails.Add(applicationUser.Email);
            }

            return applicationUserEmails;
            
        }

    }
}
