using DemoProje.Application.Bases;
using DemoProje.Application.Features.Auth.Rules;
using DemoProje.Application.Interfaces.AutoMapper;
using DemoProje.Application.Interfaces.UnitOfWorks;
using DemoProje.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace DemoProje.Application.Features.Auth.Command.Register
{
    public class RegisterCommandHandler : BaseHandler, IRequestHandler<RegisterCommandRequest, RegisterCommandResponse>
    {
        private readonly AuthRules authRules;
        private readonly UserManager<User> userManager;


        public RegisterCommandHandler(AuthRules authRules, UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.authRules = authRules;
            this.userManager = userManager;
        }

        public async Task<RegisterCommandResponse> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            await authRules.UserShouldNotBeExist(await userManager.FindByEmailAsync(request.Email));

            User user = mapper.Map<User, RegisterCommandRequest>(request);
            user.UserName = request.Email;
            user.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
               



                return new RegisterCommandResponse
                {
                    IsSuccessful = true,
                    Message = "Registration successful."
                };
            }

            return new RegisterCommandResponse
            {
                IsSuccessful = false,
                Message = "Registration failed."
            };
        }
    }
}
