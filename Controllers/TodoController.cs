﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace template.Controllers
{
	[Route("api/[controller]")]
    public class TodoController : Controller
    {

		private static List<string> _todoItems;

		static TodoController()
		{
			var list = new List<string>
			{
				"Milk",
				"Bread",
				"Eggs"
			};

			_todoItems = new List<string>(list);

		}

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
			return _todoItems;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
