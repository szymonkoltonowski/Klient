using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Klient.DAO.Queries;
using Klient.DAO.Commands;
using Klient.WebAPI.Models;
using Klient.DTO.Models;
using Serilog;
using AutoMapper;
using Klient.Model.Entities;

namespace Klient.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientController : ControllerBase
    {
        private readonly IMediator _mediator;
        readonly ILogger _logger;
        private readonly IMapper _mapper;


        public KlientController(IMediator mediator, ILogger logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Klient
        [HttpGet]
        public async Task<ActionResult> GetKlienci()
        { 
            var result = await _mediator.Send(new GetKlienciQuery());

            _logger.Debug("Próba logowania: {@result}", result);
            return Ok(result);
        }

        // GET: api/Klient/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetKlient([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetKlientByIdQuery(id));
            return Ok(_mapper.Map<KlientDTO>(result));
           //return Ok(result);
        }

        // PUT: api/Klient/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKlient([FromRoute] Guid id, [FromBody] UpdateKlientModel model)
        {
            
            var result = await _mediator.Send(new UpdateKlientCommand
            {
                Id = id,
                Pesel = model.Pesel,
                Imie = model.Imie,
                Nazwisko = model.Nazwisko,
                AdresId = model.AdresId

            });

            return Ok(result);
        }

        // POST: api/Klient
        [HttpPost]
        public async Task<IActionResult> CreateKlient([FromBody] CreateKlientModel model)
        {
            var result = await _mediator.Send(new CreateKlientCommand
            {
                Id = model.Id,
                Pesel = model.Pesel,
                Imie = model.Imie,
                Nazwisko = model.Nazwisko,
                //AdresId = model.AdresId
            });

            return Ok(result);
        }

        // DELETE: api/Klient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new DeleteKlientCommand(id));

            return Ok(result);
        }

    }
}
