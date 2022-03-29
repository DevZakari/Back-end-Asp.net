using Microsoft.AspNetCore.Mvc;
using Oper_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Oper_CRUD.Controllers
{
    [Route("api/DataEt")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApiController(AppDbContext dataContext)
        {
            _context = dataContext;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IList<Etudiant> Get()
        {
            return _context.Etudiant.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var etu = await _context.Etudiant.FindAsync(id);
            if(etu == null)
            {
                return NotFound();
            }
            _context.Etudiant.Remove(etu);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
