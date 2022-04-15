using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TradeAuditWeb.Controllers
{
    public class TestController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult TestTable()
        {
            return PartialView();
        }
    }
}
