using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TradeAuditWeb.Middlewares
{
    public class Jump404Middleware
    {

        private readonly RequestDelegate next;

        public Jump404Middleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(
            Microsoft.AspNetCore.Http.HttpContext context)
        {
            await next.Invoke(context);

            var response = context.Response;

            //如果是404就跳转到主页
            if (response.StatusCode == 404)
            {
                response.Redirect("/PageManage/PageNotFound");
            }
        }
    }
}
