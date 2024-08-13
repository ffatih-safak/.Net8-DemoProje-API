using DemoProje.Application.Interfaces.AutoMapper;
using DemoProje.Application.Interfaces.MongoDb;
using DemoProje.Application.Interfaces.UnitOfWorks;
using DemoProje.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries.Configration
{
    public class BuildingQuery : IRequest<BuildingQueryResponse>
    {
    }

    public class BuildingQueryHandler : IRequestHandler<BuildingQuery, BuildingQueryResponse>
    {

        private readonly IMongoDbService<Building> mongoService;

        public BuildingQueryHandler( IMongoDbService<Building> mongoService)
        {
            this.mongoService = mongoService;
        }

        public async Task<BuildingQueryResponse> Handle(BuildingQuery request, CancellationToken cancellationToken)
        {
            var buildings = await mongoService.GetAsync("Building");

            var response = new BuildingQueryResponse
            {
                Data = buildings,
                IsSuccessful = buildings.Count > 0,
                Message = buildings.Count > 0 ? "Success!" : "No data found!"
            };

            return response;
        }
    }
}
