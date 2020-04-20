using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Teams;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TeamsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<TeamDto>>> List()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await Mediator.Send(command);
        }
    }
}