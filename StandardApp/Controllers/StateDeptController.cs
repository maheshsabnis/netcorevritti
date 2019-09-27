using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StandardApp.Models;
using StandardApp.Services;
using StandardApp.ViewModels;

namespace StandardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateDeptController : ControllerBase
    {
        private readonly IEkatmService<StateMaster, string> stateServ;
        private readonly IEkatmService<DeptMaster, string> deptServ;

        public StateDeptController(IEkatmService<StateMaster, string> stateServ, IEkatmService<DeptMaster, string> deptServ)
        {
            this.stateServ = stateServ;
            this.deptServ = deptServ;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var states = stateServ.GetAsync().Result;
            var depts = deptServ.GetAsync().Result;
            // anonymous types C# 3.0
            // var response = new { states = states, depts = depts };
            var response = new StateDept()
            {
                States = states.ToList(),
                Depts = depts.ToList()
            };
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(StateDept stateDept) 
        {
            try
            {
                var respState = stateServ.CreateAsync(stateDept.State).Result;
                var respDept = deptServ.CreateAsync(stateDept.Dept).Result;

                var response = new { rState = respState, rDept = respDept };
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
           
        }
    }
}