using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Application.Exceptions
{
    public class ExceptionModel : ErrorStatusCode
    {
        public IEnumerable<string> Errors { get; set; }
        public string Message { get; set; }

        public bool IsSuccessful { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class ErrorStatusCode
    {
        public int StatusCode { get; set; }
    }
}
