using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatchCoreWithSwagger.Context;
using BatchCoreWithSwagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BatchCoreWithSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {

        private readonly CrudContext _CrudContext;

        public BatchController(CrudContext crudContext)
        {
            _CrudContext = crudContext;
        }
        // GET: api/<BatchController>
        [HttpGet]
        public IEnumerable<Batch> Get()
        {
            return _CrudContext.Batches;
        }

        // GET api/<BatchController>/5
        [HttpGet("{id}")]        
        public Batch Get(int id)
        {
            return _CrudContext.Batches.SingleOrDefault(s => s.BatchId == id);            
        }

        // POST api/<BatchController>
        
        [HttpPost]        
        public void Post([FromBody] Batch batch)
        {
            _CrudContext.Batches.Add(batch);
            _CrudContext.SaveChanges();
        }

        // PUT api/<BatchController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<BatchController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
