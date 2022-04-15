using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }

        public ApplicationException(string message) : base(message)
        {
        }
    }
}
