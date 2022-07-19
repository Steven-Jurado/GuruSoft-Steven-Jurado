using laboratorio.data.access;
using Laboratorio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserMaper _userMaper;

        public UserController(IUserMaper userMaper)
        {
            _userMaper = userMaper;
        }

        [HttpPost]
        [Route("adduser")]
        public async Task<IActionResult> AddUserAsync([FromBody] User user)
        {
            try
            {

                if (!TryValidateModel(user))
                    return BadRequest();

                var response = await _userMaper.AddUserGuruSoftAsync(user);

                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("listuser")]
        public async Task<IActionResult> ListUserAsync()
        {
            try
            {
                var response = await _userMaper.ListUserGuruSoftAsync();

                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
