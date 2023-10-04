using Rnn.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rnn.Specs.Api.Support
{
    public class ApiContext
    {
        public List<(object? Data, ErrorResponse? Error)> Results { get; set; } = new List<(object? Data, ErrorResponse? Error)>();
        public (object? Data, ErrorResponse? Error) CurrentResult => Results.LastOrDefault();
    }
}
