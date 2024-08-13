using DemoProje.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Features.Auth.Command.Login
{
    public class LoginCommandResponse: BaseRequestHandler
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }

    }
}
