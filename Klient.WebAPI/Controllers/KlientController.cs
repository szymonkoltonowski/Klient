﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Serilog;
using Klient.Application.Klients.Queries.GetKlient;
using Klient.Application.Klients.Queries.GetKlientById;
using Microsoft.AspNetCore.Http;
using Klient.Application.Klients.Commands.CreateKlient;
using Klient.Application.Klients.Commands.UpdateKlient;
using Klient.Application.Klients.Commands.DeleteKlient;
using Klient.DTO.Models;
using System.Collections.Generic;

namespace Klient.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientController : ControllerBase
    {
        private readonly IMediator _mediator;
        readonly ILogger _logger;


        public KlientController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/Klient
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<KlientDTO>>> GetKlienci()
        { 
            var result = await _mediator.Send(new GetKlienciQuery());

            _logger.Debug("Próba logowania: {@result}", result);

            return Ok(result);
        }

        // GET: api/Klient/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<KlientDTO>> GetKlient([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetKlientByIdQuery(id));


            return Ok(result);
        }

        // PUT: api/Klient/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> UpdateKlient([FromBody] UpdateKlientCommand model)
        {

            var result = await _mediator.Send(model);

            return Ok(result);
        }

        // POST: api/Klient
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateKlient([FromBody] CreateKlientCommand model)
        {
            var result = await _mediator.Send(model);

            return Ok(result);
        }

        // DELETE: api/Klient/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new DeleteKlientCommand(id));

            return NoContent();
            //return Ok(result);
        }

    

    }
}
