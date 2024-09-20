using ClientManagementAPIDB.Models;
using ClientManagementAPIDB.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClientManagementAPIDB.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientRepository _repository;

        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] Client client)
        {
            _repository.Add(client);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Client client)
        {
            var clientExist = _repository.GetById(id);
            if(clientExist == null)
            {
                return NotFound("Cliente não econtrado!");
            }

            client.ClientId = id;
            _repository.Update(client);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}