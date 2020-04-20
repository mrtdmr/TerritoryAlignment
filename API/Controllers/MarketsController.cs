using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Markets;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MarketsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Market>>> List()
        {
            return await Mediator.Send(new List.Query());
        }
    }
}