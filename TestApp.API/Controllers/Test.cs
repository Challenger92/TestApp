using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TestApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Testing.API.Hello
{
    [Route("testing/Hello")]
    [ApiController]

    public class HelloWorld : ControllerBase 
    {
        private readonly DataContext _outData;
        public HelloWorld(DataContext outData)
        {
            _outData = outData;

        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {

           var employees = await _outData.Employees.ToListAsync();

           return Ok(employees);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _outData.Employees.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

    }

}