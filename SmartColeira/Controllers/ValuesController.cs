﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartColeira.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        static IList<string> values = new List<string>();
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return values[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            values.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            values[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            values.RemoveAt(id);
        }
    }
}
