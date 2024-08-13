
using Azure.Core;
using DemoProje.Application.Features.Configuration.Command.CreateBuilding;
using DemoProje.Application.Features.Configuration.Queries;
using DemoProje.Application.Features.Configuration.Queries.Configration;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProje.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IMediator mediator;

        public ConfigurationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ConfigurationList()
        {
            var request = new BuildingQuery();
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        public async Task<IActionResult> BuildinTypeList()
        {
            var request = new BuildingTypeQuery();
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateConfiguration(CreateBuildingCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created, response);
        }

    }
}
