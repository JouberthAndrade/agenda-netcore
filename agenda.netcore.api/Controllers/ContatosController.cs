using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace agenda.netcore.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContatosController : ControllerBase
	{
		// GET: api/<ContatosController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<ContatosController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ContatosController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ContatosController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ContatosController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
