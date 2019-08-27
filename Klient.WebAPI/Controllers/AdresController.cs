using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Klient.Application.Adresses.Queries.GetAdres;
using Klient.Application.Adresses.Queries.GetAdresById;
using Klient.Application.Adresses.Commands.UpdateAdres;
using Klient.Application.Adresses.Commands.CreateAdres;
using Klient.Application.Adresses.Commands.DeleteAdres;
using System.Collections.Generic;
using Klient.DTO.Models;
using Microsoft.AspNetCore.Http;

namespace Klient.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresController : ControllerBase

    {
        private readonly IMediator _mediator;
        
        public AdresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Adres
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AdresDTO>>> GetAdreses()
        {
            var result = await _mediator.Send(new GetAdresQuery());
            return Ok(result);
        }

     
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AdresDTO>> GetAdres([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetAdresByIdQuery(id));
            return Ok(result);
        }

        // PUT: 
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateAdres([FromBody] UpdateAdresCommand model)
        {
            var result = await _mediator.Send(model);
 

            return Ok(result);
        }

        // POST: 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateAdres([FromBody] CreateAdresCommand model)
        {
            var result = await _mediator.Send(model);

            return Ok(result);
        }

        // DELETE: 
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new DeleteAdresCommand(id));
            return NoContent();
        }
    }
}
