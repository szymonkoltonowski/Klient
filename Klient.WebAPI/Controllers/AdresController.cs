using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Klient.WebAPI.Models;
using Klient.DAO.Models;
using Klient.DAO.Commands;
using Klient.DAO.Queries;

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
        public async Task<ActionResult> GetAdres()
        {
            var result = await _mediator.Send(new GetAdresQuery());
            return Ok(result);
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAdres([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetAdresByIdQuery(id));
            return Ok(result);
        }

        // PUT: 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdres([FromRoute] Guid id, [FromBody] UpdateAdresModel model)
        {
            var result = await _mediator.Send(new UpdateAdresCommand(new UpdateAdresCommandModel
            {
                Id = id,
                Miasto = model.Miasto,
                Ulica = model.Ulica,
                NrDomu = model.NrDomu,
                NrMieszkania = model.NrMieszkania

            }));

            return Ok(result);
        }

        // POST: 
        [HttpPost]
        public async Task<IActionResult> CreateAdres([FromBody] CreateAdresModel model)
        {
            var result = await _mediator.Send(new CreateAdresCommand(new CreateAdresCommandModel
            {
                Id = model.Id,
                Miasto = model.Miasto,
                Ulica = model.Ulica,
                NrDomu = model.NrDomu,
                NrMieszkania = model.NrMieszkania,

            }));

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
