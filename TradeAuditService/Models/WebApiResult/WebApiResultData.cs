using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult
{
    public class WebApiResultData<T> where T:RT
    {
        public T RT { get; set; }
}
}
