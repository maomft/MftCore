using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Models.WebApiResult.MobileSingleTradeTarget
{
    public class MobileSingleTradeTargetRT:RT
    {
        public List<TARGETINDEX> TARGETINDEX { get; set; }
    }
    public class TARGETINDEX
    {
        public string NAME { get; set; }
        public string VALUE { get; set; }
    }
}
