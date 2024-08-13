using DemoProje.Application.Features.Configuration.Queries.Configration;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Command.CreateBuilding
{
    public class CreateBuildingCommandRequest : IRequest<BuildingQueryResponse>
    {
        public string BuildingTypeId { get; set; }
        public string BuildingType { get; set; }
        public decimal BuildingCost { get; set; }
        public decimal ConstructionTime { get; set; }
    }
}
