using DemoProje.Application.Bases;
using DemoProje.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Queries.Configration
{
    public class BuildingQueryResponse : BaseRequestHandler
    {
        public IList<Building> Data { get; set; }
    }
}
