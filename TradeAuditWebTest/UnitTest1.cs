using System;
using System.Collections.Generic;
using System.Text;
using TradeAuditService;
using TradeAuditService.Models.MobileApproveTaskByNodeId_Batch;
using TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch;
using TradeAuditService.Models.MobileGetTaskNodeGroup;
using TradeAuditService.Models.MobileGetTaskNodeLstByPage;
using TradeAuditService.Models.MobileSingleLimitresult;
using TradeAuditService.Models.MobileSingleTraceLog;
using TradeAuditService.Models.MobileSingleTradeDetailNew;
using TradeAuditService.Models.MobileSingleTradeTarget;
using TradeAuditService.Models.WebApiResult.MobileSingleLimitresult;
using TradeAuditService.Models.WebApiResult.SingleTraceLog;
using TradeAuditService.WebApi.Login;
using TradeAuditWeb.WebApi;
using Xunit;
using Xunit.Abstractions;

namespace TradeAuditWebTest
{
    public class UnitTest1
    {
        private ITestOutputHelper outputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        [Fact]
        public void Test1()
        {
            //登入接口测试
            //TradeAuditWeb.WebApi.TradeAuditService auditWebApiService = new TradeAuditWeb.WebApi.TradeAuditService();

            //var result = auditWebApiService.LoginIn(new LoginInInput()
            //{
            //    aPwd = "1",
            //    aUserCode = "Apptest"
            //});

            //分页查询审批数据列表信息测试

            TradeAuditAppService apiService = new TradeAuditAppService();

            //var result = apiService.MobileGetTaskNodeLstByPage();
        }

        [Fact]
        public void WebApiTest()
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            //日志
            //string s = service.MobileSingleTraceLog(new TradeAuditService.Models.MobileSingleTraceLog.MobileSingleTraceLogInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});
            //{ "Msg":"成功","Status_code":1,"Data":{ "rt":{ "RE":{ "RC":"0","RM":"查询成功"},"TL":[{ "TI":"430513","LY":"业务审批","NA":"手机审批Apptest","ON":"手机审批Apptest","RN":"手机审批角色2","SN":"步骤1","AN":"同意继续","OT":"2020-07-28 23:04:00","OE":"手机审批Apptest(审批来源:手机审批)222"},{ "TI":"430513","LY":"业务审批","NA":"张景辉","ON":"张景辉","RN":"","SN":"提交审批(流程编号：2042454，流程名称：111556)","AN":"提交成功","OT":"2018-02-27 14:32:09","OE":""}]} } }

            //限额
            //string s2 = service.MobileSingleLimitresult(new MobileSingleLimitresultInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            TradeAuditAppService appService = new TradeAuditAppService();


            //交易指标
            //string s2 = service.MobileSingleTradeTarget(new MobileSingleTradeTargetInput()
            //{
            //    aUserCode = "Apptest",
            //    aTaskId = "1750888"
            //});

            //todo 交易指标调用存在问题,null引用
            var pageResult = appService.MobileGetTaskNodeLstByPage(new MobileGetTaskNodeLstByPageInput()
            {
                aPage = "0",
                aTargetType = "OTCTRADE",
                aUserCode = "Apptest",
                aBegdate = "2019-01-01",
                aEnddate = "2050-01-01",
                aDataType = 0,
                aGroupCode = "0"
            });

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var node in pageResult.Data)
            {
                string s3 = service.MobileSingleTradeTarget(new MobileSingleTradeTargetInput()
                {
                    aUserCode = "Apptest",
                    aTaskId = node.TID
                });

                stringBuilder.Append("," + s3);
            }

            //单笔交易详细
            //var s4 = service.MobileSingleTradeDetailNew(new MobileSingleTradeDetailNewInput() { 
            //    aUserCode = "Apptest",
            //    aSysOrdId = "358567"
            //});

            //批量审核前检查
            //var s5 = service.MobileCheckBeforeActionByNodeId_Batch(new TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch.MobileCheckBeforeActionByNodeId_BatchInput() { 
            //    aDataTypeCurrent  = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //});

            //批量审核
            //var s6 = service.MobileApproveTaskByNodeId_Batch(new MobileApproveTaskByNodeId_BatchInput()
            //{
            //    aDataTypeCurrent = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //    aAction = "1",
            //});

            //分组查询
            var s7 = service.MobileGetTaskNodeGroup(new MobileGetTaskNodeGroupInput()
            {
                aTargetType = "OTCTRADE",
                aUserCode = "Apptest",
                aDataType = "0"
            });

            outputHelper.WriteLine(s7);
        }

        [Fact]
        public void ServiceTest()
        {
            TradeAuditAppService service = new TradeAuditAppService();

            //日志
            //List<TraceLog> s1 = service.MobileSingleTraceLog(new MobileSingleTraceLogInput() {
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            //查询限额结果

            //LimitData limitData = service.MobileSingleLimitresult(new MobileSingleLimitresultInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            //7.7查询单笔交易详情
            //var result = service.MobileSingleTradeDetailNew(new MobileSingleTradeDetailNewInput()
            //{
            //    aSysOrdId = "358567",
            //    aUserCode = "Appset"
            //});

            //批量审核前检查
            //var result = service.MobileCheckBeforeActionByNodeId_Batch(new MobileCheckBeforeActionByNodeId_BatchInput()
            //{
            //    aDataTypeCurrent = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //});

            //组合
            var result = service.MobileGetTaskNodeGroup(new MobileGetTaskNodeGroupInput()
            {
                aTargetType = "OTCTRADE",
                aUserCode = "Apptest",
                aDataType = "0"
            });

            var apiService = new TradeAuditWebApiService();
            foreach (var item in result)
            {
                string v = apiService.MobileGetTaskNodeLstByPage(new MobileGetTaskNodeLstByPageInput()
                {
                    aBegdate = "2014-01-01",
                    aDataType = 0,
                    aEnddate = "2020-08-08",
                    aTargetType= "OTCTRADE",
                    aGroupCode = item.C,
                    aPage = "1",
                    aUserCode = "Apptest"
                });
            }
        }
    }
}
