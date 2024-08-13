using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries.Configration
{
    public class BuildingQueryRequest : IRequest<IList<BuildingQueryResponse>>
    {
    }
}
