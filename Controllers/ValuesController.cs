using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestEntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly TestDbContext db;
        public ValuesController(TestDbContext _db)
        {
            db = _db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var customers = (from c in db.Customer
                             where c.Country_Code == "US"
                             select c).ToList();
            return Ok(customers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
