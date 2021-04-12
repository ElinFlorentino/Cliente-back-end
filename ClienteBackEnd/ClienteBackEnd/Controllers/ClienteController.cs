using ClienteBackEnd.Data.services;
using ClienteBackEnd.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClienteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteService _clienteService;
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public IActionResult GetAllCliente()
        {
            try
            {
               var allClientes = _clienteService.GetAllClientes();
                return Ok(allClientes);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // GET api/<ClienteController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult addCliente([FromBody] ClienteVM cliente)
        {
            try
            {
                _clienteService.addCliente(cliente);
                return Ok(cliente);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public IActionResult updateClienteById(int id, [FromBody] ClienteVM cliente)
        {
            try
            {
                var updateCliente = _clienteService.updateClienteById(id,cliente);
                return Ok(updateCliente);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public IActionResult deleteClienteByID(int id)
        {
            try
            {
                _clienteService.deleteClieteById(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
