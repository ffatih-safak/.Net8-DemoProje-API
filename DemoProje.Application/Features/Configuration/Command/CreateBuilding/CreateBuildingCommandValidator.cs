using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Configuration.Command.CreateBuilding
{
    public class CreateBuildingCommandValidator : AbstractValidator<CreateBuildingCommandRequest>
    {
        public CreateBuildingCommandValidator()
        {
            RuleFor(x => x.BuildingType)
                .NotEmpty()
                .WithName("BuildingType");
            RuleFor(x => x.BuildingCost)
                       .NotEmpty()
                       .GreaterThan(0)
                       .WithName("BuildingCost")
                       .WithMessage("Building cost couldn't be zero or a negative number.");
            RuleFor(x => x.ConstructionTime)
                       .NotEmpty()
                       .InclusiveBetween(30, 1800)
                       .WithName("ConstructionTime")
                       .WithMessage("Construction time should be minimum 30 seconds and maximum 1800 seconds.");



        }
    }
}
