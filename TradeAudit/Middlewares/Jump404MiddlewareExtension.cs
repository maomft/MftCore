using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace TradeAuditWeb.Middlewares
{
    public static class Jump404MiddlewareExtension
    {
        public static IApplicationBuilder UseJump404(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Jump404Middleware>();
        }
    }
}
