﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OPTICIP.API.Application.Commands.PreparationCommands;
using OPTICIP.API.Application.Queries.Interfaces;
using OPTICIP.API.Application.Queries.ViewModels;
using OPTICIP.Entities.DataEntities;
using OPTICIP.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace OPTICIP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class PreparationApiController : ControllerBase
    {

        private readonly IPreparationQueries _preparationQueries;
        private readonly IDetectionQueries _detectionQueries;
        public PreparationApiController(IPreparationQueries preparationQueries, IDetectionQueries detectionQueries)
        {
            _preparationQueries = preparationQueries ?? throw new ArgumentNullException(nameof(preparationQueries));
            _detectionQueries = detectionQueries ?? throw new ArgumentNullException(nameof(detectionQueries));
        }

        [HttpGet]
        [Route("PreparationComptes")]
        [ProducesResponseType(typeof(IEnumerable<TCompte>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationComptes(string userID)
        {
            await _detectionQueries.LancerDetectionComptes(userID);
            var result = await _preparationQueries.LancerPreparationComptes(userID);        
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationPersonnesPhysiques")]
        [ProducesResponseType(typeof(IEnumerable<TPersPhysique>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationPersonnesPhysiques(string userID)
        {
            await _detectionQueries.LancerDetectionPersonnesPhysiques(userID);
            var result = await _preparationQueries.LancerPreparationPersonnesPhysiques(userID);
            return Ok(result);  
        }

        [HttpGet]
        [Route("PreparationPersonnesMorales")]
        [ProducesResponseType(typeof(IEnumerable<TPersMorale>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationPersonnesMorales(string userID)
        {
            await _detectionQueries.LancerDetectionPersonnesMorales(userID);
            var result = await _preparationQueries.LancerPreparationPersonnesMorales(userID);
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationCartes")]
        [ProducesResponseType(typeof(IEnumerable<TCarte>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationCartes(string userID)
        {
            await _detectionQueries.LancerDetectionCartes(userID);
            var result = await _preparationQueries.LancerPreparationCartes(userID);
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationCheques")]
        [ProducesResponseType(typeof(IEnumerable<TIncidentCheque>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationCheques(string userID)
        {
            await _detectionQueries.LancerDetectionCheques(userID);
            var result = await _preparationQueries.LancerPreparationCheques(userID);
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationChequesIrreguliers")]
        [ProducesResponseType(typeof(IEnumerable<TChequeIrregulier>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationChequesIrreguliers(string userID)
        {
            await _detectionQueries.LancerDetectionChequesIrreguliers(userID);
            var result = await _preparationQueries.LancerPreparationChequesIrreguliers(userID);
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationEffets")]
        [ProducesResponseType(typeof(IEnumerable<TIncidentEffet>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationEffets(string userID)
        {
            await _detectionQueries.LancerDetectionEffets(userID);
            var result = await _preparationQueries.LancerPreparationEffets(userID);
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialeComptes")]
        [ProducesResponseType(typeof(IEnumerable<CIP1ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialeComptes()
        {
            await _detectionQueries.LancerDetectionComptes("");
            var result = await _preparationQueries.LancerPreparationInitialeComptes();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialePersonnesPhysiques")]
        [ProducesResponseType(typeof(IEnumerable<CIP2ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialePersonnesPhysiques()
        {
            await _detectionQueries.LancerDetectionPersonnesPhysiques("");
            var result = await _preparationQueries.LancerPreparationInitialePersonnesPhysiques();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialePersonnesMorales")]
        [ProducesResponseType(typeof(IEnumerable<CIP3ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialePersonnesMorales()
        {
            await _detectionQueries.LancerDetectionPersonnesMorales("");
            var result = await _preparationQueries.LancerPreparationInitialePersonnesMorales();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialeCheques")]
        [ProducesResponseType(typeof(IEnumerable<CIP5ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialeCheques()
        {
            await _detectionQueries.LancerDetectionCheques("");
            var result = await _preparationQueries.LancerPreparationInitialeCheques();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialeChequesIrreguliers")]
        [ProducesResponseType(typeof(IEnumerable<CIP6ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialeChequesIrreguliers()
        {
            await _detectionQueries.LancerDetectionChequesIrreguliers("");
            var result = await _preparationQueries.LancerPreparationInitialeChequesIrreguliers();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationInitialeEffets")]
        [ProducesResponseType(typeof(IEnumerable<CIP7ViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationInitialeEffets()
        {
            await _detectionQueries.LancerDetectionEffets("");
            var result = await _preparationQueries.LancerPreparationInitialeEffets();
            return Ok(result);
        }

        [HttpGet]
        [Route("PreparationDonnees")]
        [ProducesResponseType(typeof(IEnumerable<TDonnees_A_Declarer>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PreparationDonnees(string agence)
        {
            var result = await _preparationQueries.LancerPreparationDonnees(agence);
            return Ok(result);
        }

        [HttpGet]
        [Route("TraitementCheques")]
        public async Task<IActionResult> TraitementCheques()
        {
            await _detectionQueries.LancerTraitementCheques();
            return Ok();
        }

        [HttpGet]
        [Route("ListIncidChqEb")]
        [ProducesResponseType(typeof(IEnumerable<IncidChqEbViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ListIncidChqEb()
        {
            var result = await _detectionQueries.GetIncidChqEbAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetIncidChqEb")]
        [ProducesResponseType(typeof(IEnumerable<IncidChqEbViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetIncidChqEb(string compte, string cheque, string dateOperation)
        {
            var Datoper = String.IsNullOrEmpty(dateOperation) ? DateTime.MinValue : DateTime.Parse(dateOperation);
            var result = await _detectionQueries.GetIncidChqEbAsync(compte, cheque, Datoper);
            return Ok(result);
        }

        [HttpGet]
        [Route("ListIncidChq")]
        [ProducesResponseType(typeof(IEnumerable<IncidChqViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ListIncidChq()
        {
            var result = await _detectionQueries.GetIncidChqAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetIncidChq")]
        [ProducesResponseType(typeof(IEnumerable<IncidChqViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetIncidChq(string compte, string cheque)
        {
            var result = await _detectionQueries.GetIncidChqAsync(compte, cheque);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatIncidentChqEB")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PutUpdatIncidentChqEB([FromBody]UpdateIncidentChqEbCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            var result = await _detectionQueries.UpdateIncidChqEbAsync(command.Compte, command.Cheque, command.Datoper, command.Beneficiaire, command.Dateemi);
            return result >= 1 ? (IActionResult)Ok() : (IActionResult)BadRequest();
        }

        [HttpPut]
        [Route("UpdatIncidentChq")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PutUpdatIncidentChq([FromBody]UpdateIncidentChqCommand command, [FromHeader(Name = "x-requestid")] string requestId)
        {
            var result = await _detectionQueries.UpdateIncidChqAsync(command.Compte, command.Cheque, command.DateRegulatisation, command.DatJustification,command.MotifRegularisation,command.NumeroPenalite,command.MontantPenalite);

            if (result >= 1)
                return (IActionResult)Ok();
            else
                return (IActionResult)BadRequest();
        }
    }
}