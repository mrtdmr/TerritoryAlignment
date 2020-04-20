﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Plans;
using Application.Plans.Dtos;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PlansController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<PlanDto>>> List()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await Mediator.Send(command);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanDto>> Details(Guid id)
        {
            return await Mediator.Send(new Detail.Query { Id = id });
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Update(Guid id, Update.Commmand command)
        {
            command.Id = id;
            return await Mediator.Send(command);
        }
    }
}