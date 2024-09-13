using Microsoft.AspNetCore.Mvc;
using RDI.BIBLIOTECA.Domain;
using RDI.BIBLIOTECA.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RDI.API.Controllers
{   
    
    [Route("api/[controller]")]
    [ApiController]
    public class GeladeiraController : ControllerBase 

    {
        private readonly IGeladeiraService _service;
        public GeladeiraController(IGeladeiraService service)
        {
            _service = service;
        }
        // GET: api/<GeladeiraController>
        [HttpGet]
        public ActionResult GetAll() {

            var list = _service.GetAll();

            return Ok(list );
        }

        // GET api/<GeladeiraController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Item item= _service.GetById(id);

            return Ok(item);
        }

        // POST api/<GeladeiraController>
        [HttpPost]
        public ActionResult Post([FromBody] Item item)
        {
            Item insert = _service.Insert(item);
            return Ok(insert);
        }

        // PUT api/<GeladeiraController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] Item item)
        {
            Item alterar = _service.Update(item);
            return Ok(alterar);
        }

        // DELETE api/<GeladeiraController>/5
        [HttpDelete()]
        public ActionResult Delete([FromBody]Item item)
        {
            Item deletar = _service.Remove(item);
            return Ok(deletar);
        }
    }
}
