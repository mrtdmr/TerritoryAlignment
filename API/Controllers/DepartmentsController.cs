using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Departments;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DepartmentsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Department>>> List()
        {
            return await Mediator.Send(new List.Query());
        }
    }
}