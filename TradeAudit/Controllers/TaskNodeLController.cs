using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KindeeDataSynchronizationService.Models;
using Microsoft.AspNetCore.Mvc;
using TradeAuditService.Models.MobileApproveTaskByNodeId_Batch;
using TradeAuditService.Models.MobileGetTaskNodeGroup;
using TradeAuditService.Models.MobileGetTaskNodeLstByPage;
using TradeAuditService.Models.MobileSingleLimitresult;
using TradeAuditService.Models.MobileSingleTaskNodeTree;
using TradeAuditService.Models.MobileSingleTraceLog;
using TradeAuditService.Models.MobileSingleTradeDetailNew;
using TradeAuditService.Models.MobileSingleTradeTarget;
using TradeAuditWeb.WebApi;

namespace TradeAuditWeb.Controllers
{
    public class TaskNodeLController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 分页查询审批数据列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult MobileGetTaskNodeLstByPage()
        {
            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileGetTaskNodeLstByPage(new MobileGetTaskNodeLstByPageInput()
            {
                aPage = "0",
                aTargetType = "OTCTRADE",
                aUserCode = "Apptest",
                aBegdate = "2019-01-01",
                aEnddate = "2050-01-01",
                aDataType = 0,
                aGroupCode = "0"
            });

            return Json(result);
        }

        /// <summary>
        /// 审核列表页面
        /// </summary>
        public IActionResult MobileGetTaskNodeLstByPageView()
        {
            return View();
        }

        /// <summary>
        /// 审批数据分组页面
        /// </summary>
        public IActionResult MobileGetTaskNodeGroupView()
        {
            return View();

        }

        /// <summary>
        /// 组合明细页面
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IActionResult MobileGetTaskNodeGroupDetailView(string c)
        {
            ViewBag.C = c;
            return View();
        }

        /// <summary>
        /// 组合明细
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IActionResult MobileGetTaskNodeGroupDetail(string c)
        {
            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileGetTaskNodeLstByPage(new MobileGetTaskNodeLstByPageInput()
            {
                aPage = "0",
                aTargetType = "OTCTRADE",
                aUserCode = "Apptest",
                aBegdate = "2014-01-01",
                aEnddate = "2050-01-01",
                aDataType = 0,
                aGroupCode = c
            });

            return Json(result);
        }

        /// <summary>
        /// 7.3查询单笔审批单审批流程图
        /// </summary>
        /// <returns></returns>

        public IActionResult MobileSingleTaskNodeTree(MobileSingleTaskNodeTreeInput input)
        {
            if (string.IsNullOrEmpty(input.aTaskId)) throw new ApplicationException("请选择对应的审核流程");
            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();

            var result = service.MobileSingleTaskNodeTree(input);

            //todo 发布注释
            //var result = "{\"Msg\":\"成功\",\"Status_code\":1,\"Data\":{\"rt\":{\"RE\":{\"RC\":\"0\",\"RM\":\"查询成功\"},\"T\":{\"ID\":\"TASK\",\"TX\":\"11_sjsp_01\",\"VA\":\"2042454\",\"IN\":\"\",\"TY\":\"ROOT\",\"LE\":\"0\",\"IC\":\"0\",\"T\":[{\"ID\":\"6524877T0\",\"TX\":\"步骤1\",\"VA\":\"6524877\",\"IN\":\"True\",\"TY\":\"STEP\",\"LE\":\"1\",\"IC\":\"1\",\"T\":[{\"ID\":\"341222R0\",\"TX\":\"手机审批角色2\",\"VA\":\"341222\",\"IN\":\"True\",\"TY\":\"ROLE\",\"LE\":\"2\",\"IC\":\"3\"},{\"ID\":\"341221R1\",\"TX\":\"手机审批角色1\",\"VA\":\"341221\",\"IN\":\"True\",\"TY\":\"ROLE\",\"LE\":\"2\",\"IC\":\"3\"}]},{\"ID\":\"6524879T2\",\"TX\":\"步骤2\",\"VA\":\"6524879\",\"IN\":\"True\",\"TY\":\"STEP\",\"LE\":\"1\",\"IC\":\"1\",\"T\":{\"ID\":\"341223R2\",\"TX\":\"手机审批角色3\",\"VA\":\"341223\",\"IN\":\"True\",\"TY\":\"ROLE\",\"LE\":\"2\",\"IC\":\"3\"}},{\"ID\":\"6524880T3\",\"TX\":\"步骤3\",\"VA\":\"6524880\",\"IN\":\"True\",\"TY\":\"STEP\",\"LE\":\"1\",\"IC\":\"1\",\"T\":[{\"ID\":\"341224R3\",\"TX\":\"手机审批角色4\",\"VA\":\"341224\",\"IN\":\"True\",\"TY\":\"ROLE\",\"LE\":\"2\",\"IC\":\"3\"},{\"ID\":\"528781R4\",\"TX\":\"手机审批角色5\",\"VA\":\"528781\",\"IN\":\"True\",\"TY\":\"ROLE\",\"LE\":\"2\",\"IC\":\"3\"}]}]}}}}";
            Response.ContentType = "application/json; charset=utf-8";
            return Content(result);
        }

        /// <summary>
        /// 7.3单笔审批单审批流程图
        /// </summary>
        /// <returns></returns>

        public IActionResult MobileSingleTaskNodeTreeView()
        {
            ViewBag.aTaskId = Request.Query["aTaskId"];
            return View();
        }

        /// <summary>
        /// 7.4查询审批日志
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult MobileSingleTraceLog(MobileSingleTraceLogInput input)
        {
            if (string.IsNullOrEmpty(input.aTaskId)) throw new ApplicationException("请选择对应的审核流程");
            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileSingleTraceLog(input);

            return Json(result);
        }

        /// <summary>
        /// 7.5查询限额检查结果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult MobileSingleLimitresult(MobileSingleLimitresultInput input)
        {
            if (string.IsNullOrEmpty(input.aTaskId)) throw new ApplicationException("请选择对应的审核流程");
            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileSingleLimitresult(input);
            if (result == null) throw new ApplicationException("没有限额数据");
            
            return Json(result);
        }

        /// <summary>
        /// 7.6 查询交易指标
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult MobileSingleTradeTarget(MobileSingleTradeTargetInput input)
        {
            if (string.IsNullOrEmpty(input.aTaskId)) throw new ApplicationException("请选择对应的审核流程");
            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileSingleTradeTarget(input);
            if (result == null||result.Count<=0) throw new ApplicationException("没有限额数据");

            return Json(result);
        }

        /// <summary>
        /// 7.7查询单笔交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult MobileSingleTradeDetailNew(MobileSingleTradeDetailNewInput input)
        {
            if (string.IsNullOrEmpty(input.aSysOrdId)) throw new ApplicationException("请选择对应的数据");

            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();
            var result = service.MobileSingleTradeDetailNew(input);

            if (result == null) throw new ApplicationException("没有交易明细的数据");

            ViewBag.aTaskId = Request.Query["aTaskId"];

            return View(result);
        }

        /// <summary>
        /// 7.9.1 批量审批操作同意
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void MobileApproveTaskByNodeId_BatchAgree(MobileApproveTaskByNodeId_BatchInput input)
        {
            if (string.IsNullOrEmpty(input.aNodeIds)) throw new ApplicationException("请选择对应的数据");

            input.aUserCode = GetCurrentUserCode();
            input.aAction = ((int)AActionEnum.AgreeContinue).ToString();
            TradeAuditAppService service = new TradeAuditAppService();

            service.MobileApproveTaskByNodeId_BatchAgree(input);
        }

        /// <summary>
        /// 7.9.2 批量审批操作拒绝
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void MobileApproveTaskByNodeId_BatchRefuse(MobileApproveTaskByNodeId_BatchInput input)
        {
            if (string.IsNullOrEmpty(input.aNodeIds)) throw new ApplicationException("请选择对应的数据");

            input.aUserCode = GetCurrentUserCode();
            input.aAction = ((int)AActionEnum.Refuse).ToString();

            TradeAuditAppService service = new TradeAuditAppService();

            service.MobileApproveTaskByNodeId_BatchRefuse(input);
        }
        /// <summary>
        /// 7.10查询审批数据分组信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult MobileGetTaskNodeGroup(MobileGetTaskNodeGroupInput input)
        {
            input.aUserCode = GetCurrentUserCode();

            TradeAuditAppService service = new TradeAuditAppService();

            var list = service.MobileGetTaskNodeGroup(input);

            return Json(new PageResult<TradeAuditService.Models.WebApiResult.MobileGetTaskNodeGroup.G>(list?.Count ?? 0, list));
        }
    }
}
