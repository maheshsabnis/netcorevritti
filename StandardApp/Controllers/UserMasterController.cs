using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StandardApp.Models;
using StandardApp.Services;
namespace StandardApp.Controllers
{
    // api/controller/[action]
    [Route("api/[controller]")]
    [ApiController] // map the data from body of Http Post and Put  requests
                    // in .NET Core 2.0+
                    // ControllerBase, manages 
                    // 1. Security, 2. Request Processing, 3. Generate Responses
    public class UserMasterController : ControllerBase
    {
        private readonly IEkatmService<UserMaster, Guid> _userMasterService;

        /// <summary>
        /// Inject the Service class
        /// </summary>
        public UserMasterController(IEkatmService<UserMaster, Guid> userMasterService)
        {
            _userMasterService = userMasterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var users = _userMasterService.GetAsync().Result;

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var user = _userMasterService.GetAsync(id).Result;
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost()]
        public IActionResult Post(UserMaster user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _userMasterService.CreateAsync(user).Result;

                    return Ok(response);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}