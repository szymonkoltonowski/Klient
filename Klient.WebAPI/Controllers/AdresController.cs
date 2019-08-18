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
        public async Task<ActionResult<IEnumerable<AdresDTO>>> GetAdreses()
        {
            System.Collections.Generic.IEnumerable<Model.Entities.AdresEntity> result = await _mediator.Send(new GetAdresQuery());
            return Ok(result);
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AdresDTO>>> GetAdres([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetAdresByIdQuery(id));
            return Ok(result);
        }

        // PUT: 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdres([FromRoute] Guid id, [FromBody] UpdateAdresCommand model)
        {
            var result = await _mediator.Send(new UpdateAdresCommand
            {
                Id = id,
                Miasto = model.Miasto,
                Ulica = model.Ulica,
                NrDomu = model.NrDomu,
                NrMieszkania = model.NrMieszkania

            });

            return Ok(result);
        }

        // POST: 
        [HttpPost]
        public async Task<IActionResult> CreateAdres([FromBody] CreateAdresCommand model)
        {
            var result = await _mediator.Send(model);

            return Ok(result);
        }

        // DELETE: 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new DeleteAdresCommand(id));

            return Ok(result);
        }
    }
}
