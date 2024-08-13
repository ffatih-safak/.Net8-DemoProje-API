using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Auth.Command.Register
{
    public class RegisterCommandRequest :  IRequest<RegisterCommandResponse>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
