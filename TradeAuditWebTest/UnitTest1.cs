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
            //����ӿڲ���
            //TradeAuditWeb.WebApi.TradeAuditService auditWebApiService = new TradeAuditWeb.WebApi.TradeAuditService();

            //var result = auditWebApiService.LoginIn(new LoginInInput()
            //{
            //    aPwd = "1",
            //    aUserCode = "Apptest"
            //});

            //��ҳ��ѯ���������б���Ϣ����

            TradeAuditAppService apiService = new TradeAuditAppService();

            //var result = apiService.MobileGetTaskNodeLstByPage();
        }

        [Fact]
        public void WebApiTest()
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            //��־
            //string s = service.MobileSingleTraceLog(new TradeAuditService.Models.MobileSingleTraceLog.MobileSingleTraceLogInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});
            //{ "Msg":"�ɹ�","Status_code":1,"Data":{ "rt":{ "RE":{ "RC":"0","RM":"��ѯ�ɹ�"},"TL":[{ "TI":"430513","LY":"ҵ������","NA":"�ֻ�����Apptest","ON":"�ֻ�����Apptest","RN":"�ֻ�������ɫ2","SN":"����1","AN":"ͬ�����","OT":"2020-07-28 23:04:00","OE":"�ֻ�����Apptest(������Դ:�ֻ�����)222"},{ "TI":"430513","LY":"ҵ������","NA":"�ž���","ON":"�ž���","RN":"","SN":"�ύ����(���̱�ţ�2042454���������ƣ�111556)","AN":"�ύ�ɹ�","OT":"2018-02-27 14:32:09","OE":""}]} } }

            //�޶�
            //string s2 = service.MobileSingleLimitresult(new MobileSingleLimitresultInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            TradeAuditAppService appService = new TradeAuditAppService();


            //����ָ��
            //string s2 = service.MobileSingleTradeTarget(new MobileSingleTradeTargetInput()
            //{
            //    aUserCode = "Apptest",
            //    aTaskId = "1750888"
            //});

            //todo ����ָ����ô�������,null����
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

            //���ʽ�����ϸ
            //var s4 = service.MobileSingleTradeDetailNew(new MobileSingleTradeDetailNewInput() { 
            //    aUserCode = "Apptest",
            //    aSysOrdId = "358567"
            //});

            //�������ǰ���
            //var s5 = service.MobileCheckBeforeActionByNodeId_Batch(new TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch.MobileCheckBeforeActionByNodeId_BatchInput() { 
            //    aDataTypeCurrent  = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //});

            //�������
            //var s6 = service.MobileApproveTaskByNodeId_Batch(new MobileApproveTaskByNodeId_BatchInput()
            //{
            //    aDataTypeCurrent = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //    aAction = "1",
            //});

            //�����ѯ
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

            //��־
            //List<TraceLog> s1 = service.MobileSingleTraceLog(new MobileSingleTraceLogInput() {
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            //��ѯ�޶���

            //LimitData limitData = service.MobileSingleLimitresult(new MobileSingleLimitresultInput()
            //{
            //    aUserCode = "Appset",
            //    aTaskId = "2042673"
            //});

            //7.7��ѯ���ʽ�������
            //var result = service.MobileSingleTradeDetailNew(new MobileSingleTradeDetailNewInput()
            //{
            //    aSysOrdId = "358567",
            //    aUserCode = "Appset"
            //});

            //�������ǰ���
            //var result = service.MobileCheckBeforeActionByNodeId_Batch(new MobileCheckBeforeActionByNodeId_BatchInput()
            //{
            //    aDataTypeCurrent = "0",
            //    aNodeIds = "6524919",
            //    aUserCode = "Apptest",
            //    targetType = "OTCTRADE",
            //});

            //���
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
