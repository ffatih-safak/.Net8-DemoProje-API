using DemoProje.Application.Features.Configuration.Queries.Configration;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries
{
    public class BuildingTypeQueryRequest : IRequest<IList<BuildingTypeQueryResponse>>
    {
    }
}
