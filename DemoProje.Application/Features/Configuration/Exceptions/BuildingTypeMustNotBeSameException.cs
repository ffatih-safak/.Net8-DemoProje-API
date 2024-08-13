using DemoProje.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Exceptions
{

    public class BuildingTypeMustNotBeSameException : BaseException
    {
        public BuildingTypeMustNotBeSameException() : base("This Building Type already exists!") { }
    }
}
