using DemoProje.Application.Features.Configuration.Queries.Configration;
using DemoProje.Application.Interfaces.MongoDb;
using DemoProje.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries
{
    public class BuildingTypeQuery : IRequest<BuildingTypeQueryResponse>
    {
    }

    public class BuildingTypeQueryHandler : IRequestHandler<BuildingTypeQuery, BuildingTypeQueryResponse>
    {

        private readonly IMongoDbService<Building> mongoBuildingService;
        private readonly IMongoDbService<BuildingType> mongoBuildingTypeService;

        public BuildingTypeQueryHandler(IMongoDbService<Building> mongoBuildingService, IMongoDbService<BuildingType> mongoBuildingTypeService)
        {
            this.mongoBuildingService = mongoBuildingService;
            this.mongoBuildingTypeService = mongoBuildingTypeService;
        }

        public async Task<BuildingTypeQueryResponse> Handle(BuildingTypeQuery request, CancellationToken cancellationToken)
        {

            var buildings = await mongoBuildingService.GetAsync("Building");

            var buildingtypes = await mongoBuildingTypeService.GetAsync("BuildingType");

            var buildingTypeIdsInBuildings = buildings.Select(b => b.BuildingTypeId).ToList();

            buildingtypes = buildingtypes.Where(bt => !buildingTypeIdsInBuildings.Contains(bt.Id)).ToList();

            var response = new BuildingTypeQueryResponse
            {
                Data = buildingtypes,
                IsSuccessful = buildingtypes.Count > 0,
                Message = buildingtypes.Count > 0 ? "Success!" : "No data found!"
            };

            return response;
        }
    }

}
