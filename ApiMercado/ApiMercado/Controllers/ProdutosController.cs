using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ApiMercado.Controllers
{
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        // GET api/produtos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/produtos/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/produtos
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/produtos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/produtos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
