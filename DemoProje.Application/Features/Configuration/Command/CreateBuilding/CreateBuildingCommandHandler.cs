using DemoProje.Application.Bases;
using DemoProje.Application.Features.Configuration.Queries;
using DemoProje.Application.Features.Configuration.Queries.Configration;
using DemoProje.Application.Interfaces.AutoMapper;
using DemoProje.Application.Interfaces.MongoDb;
using DemoProje.Application.Interfaces.UnitOfWorks;
using DemoProje.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Command.CreateBuilding
{
    public class CreateBuildingCommandHandler : BaseHandler, IRequestHandler<CreateBuildingCommandRequest, BuildingQueryResponse>
    {
        private readonly IMongoDbService<Building> mongoService;
        private readonly IMapper mapper;
        public CreateBuildingCommandHandler(IMongoDbService<Building> mongoService, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.mongoService = mongoService;
            this.mapper = mapper;
        }

        public async Task<BuildingQueryResponse> Handle(CreateBuildingCommandRequest request, CancellationToken cancellationToken)
        {

            var building = mapper.Map<Building, CreateBuildingCommandRequest>(request);

           await mongoService.CreateAsync(building, "Building");

            var buildings = new List<Building> { building };
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
