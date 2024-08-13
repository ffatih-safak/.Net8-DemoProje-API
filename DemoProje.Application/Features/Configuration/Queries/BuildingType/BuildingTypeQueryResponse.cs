using DemoProje.Application.Bases;
using DemoProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries
{
    public class BuildingTypeQueryResponse : BaseRequestHandler
    {
        public IList<BuildingType> Data { get; set; }
    }
}
