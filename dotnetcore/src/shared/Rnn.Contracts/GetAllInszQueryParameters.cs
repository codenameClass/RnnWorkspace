using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rnn.Contracts
{
    public class GetAllInszQueryParameters
    {
        public string? Date { get; set; }
        public string? Amount { get; set; }
        public string? Info { get; set; }
        public string? Adult { get; set; }
    }

}
