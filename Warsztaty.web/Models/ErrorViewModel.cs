using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warsztaty.web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { set; get; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
