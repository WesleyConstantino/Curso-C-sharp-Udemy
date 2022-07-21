using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancária__exceções_.Entities.Exceptions
{
    class Exception : ApplicationException
    {
        public Exception(string message) : base(message)
        {
        }
    }
}
