using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Cities;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CitiesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<City>>> List()
        {
            return await Mediator.Send(new List.Query());
        }
    }
}