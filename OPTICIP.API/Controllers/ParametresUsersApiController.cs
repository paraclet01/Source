﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OPTICIP.API.Application.Commands.AgencesCommands;
using OPTICIP.API.Application.Commands.UsersCommands;
using OPTICIP.API.Application.Queries.Interfaces;
using OPTICIP.API.Application.Queries.ViewModels;

namespace OPTICIP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class ParametresUsersApiController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IParametresQuerie _parametreQueries;
        public ParametresUsersApiController(IMediator mediator, IParametresQuerie parametreQueries /*, IIdentityService identityService*/)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _parametreQueries = parametreQueries ?? throw new ArgumentNullException(nameof(parametreQueries));
        }

        [HttpGet]
        [Route("ListParametres")]
        [ProducesResponseType(typeof(IEnumerable<ParametresViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetListParametres()
        {
            try
            {
                var Parametres = await _parametreQueries.GetAllParametresAsync();
                return Ok(Parametres);
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ParametreItem")]
        [ProducesResponseType(typeof(ParametresViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GeParametreItem(String Id)
        {
            try
            {
                var Parametre = await _parametreQueries.GetParametresByIdAsync(int.Parse(Id));
                return Ok(Parametre);
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ListAgences")]
        [ProducesResponseType(typeof(IEnumerable<AgencesViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetListAgences()
        {
            try
            {
                var Parametres = await _parametreQueries.GetAgencesAsync();
                return Ok(Parametres);
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("CreateAgence")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostCreateAgence([FromBody] CreateAgenceCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            try
            {
                bool commandResult = false;
                //if (Guid.TryParse(requestId, out Guid guid) && guid != Guid.Empty)
                //{
                //    commandResult = await _mediator.Send(command);
                //}

                commandResult = await _mediator.Send(command);
                return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("Agence")]
        [ProducesResponseType(typeof(AgencesViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAgence(string Id)
        {
            try
            {
                var agence = await _parametreQueries.GetAgenceAsync(Guid.Parse(Id));

                return Ok(agence);
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateAgence")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PutUpdateAgence([FromBody] UpdateAgenceCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            try
            {
                bool commandResult = false;
                //if (Guid.TryParse(requestId, out Guid guid) && guid != Guid.Empty)
                //{
                //    commandResult = await _mediator.Send(command);
                //}
                commandResult = await _mediator.Send(command);
                return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("DeleteAgence")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PutDeleteAgence([FromBody] DeleteAgenceCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            try
            {
                bool commandResult = false;
                //if (Guid.TryParse(requestId, out Guid guid) && guid != Guid.Empty)
                //{
                //    commandResult = await _mediator.Send(command);
                //}
                commandResult = await _mediator.Send(command);
                return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateParametre")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PutUpdateParametre([FromBody] UpdateParametreCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            try
            {
                bool commandResult = false;
                //if (Guid.TryParse(requestId, out Guid guid) && guid != Guid.Empty)
                //{
                //    commandResult = await _mediator.Send(command);
                //}
                commandResult = await _mediator.Send(command);
                return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();
            }
            catch (Exception e)
            {
                Logger.ApplicationLogger.LogError(e);
                return (IActionResult)BadRequest(e.Message);
            }
        }

    }
}