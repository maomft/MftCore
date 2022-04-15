using KindeeDataSynchronizationService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TradeAuditService;
using TradeAuditService.Helper;
using TradeAuditService.Models;
using TradeAuditService.Models.MobileApproveTaskByNodeId_Batch;
using TradeAuditService.Models.MobileCheckBeforeActionByNodeId_Batch;
using TradeAuditService.Models.MobileGetTaskNodeGroup;
using TradeAuditService.Models.MobileGetTaskNodeLstByPage;
using TradeAuditService.Models.MobileSingleLimitresult;
using TradeAuditService.Models.MobileSingleTaskNodeTree;
using TradeAuditService.Models.MobileSingleTraceLog;
using TradeAuditService.Models.MobileSingleTradeDetailNew;
using TradeAuditService.Models.MobileSingleTradeTarget;
using TradeAuditService.Models.WebApiResult;
using TradeAuditService.Models.WebApiResult.CheckBeforeActionByNodeId_Batch;
using TradeAuditService.Models.WebApiResult.Login;
using TradeAuditService.Models.WebApiResult.MobileGetTaskNodeGroup;
using TradeAuditService.Models.WebApiResult.MobileSingleLimitresult;
using TradeAuditService.Models.WebApiResult.MobileSingleTaskNodeTree;
using TradeAuditService.Models.WebApiResult.MobileSingleTradeTarget;
using TradeAuditService.Models.WebApiResult.SingleTraceLog;
using TradeAuditService.Models.WebApiResult.SingleTradeDetailNew;
using TradeAuditService.Models.WebApiResult.TaskNodeLst;
using TradeAuditService.WebApi.Login;

namespace TradeAuditWeb.WebApi
{
    public class TradeAuditAppService
    {
        public LoginInOutput LoginIn(LoginInInput input)
        {
            var apiService = new TradeAuditWebApiService();
            string response = apiService.LoginIn(input);

            var responseData = WebApiResultModel<LoginInRT>.CreateInstance(response);

            CheckResponseData(responseData);

            var outPut = new LoginInOutput() { aPwd = input.aPwd, aUserCode = input.aUserCode, };

            if (responseData.Data != null && responseData.Data.RT != null && responseData.Data.RT.M != null &&
                responseData.Data.RT.M.Count > 0)
            {
                outPut.Menus = responseData.Data.RT.M.Where(m => m.I).ToList();
            }

            outPut.Menus = new List<MenuInfo>()
            {
                new MenuInfo(){ C = "123", I = true, N = "测试名称"}
        };

            return outPut;

        }

        /// <summary>
        /// 分页查询审批数据列表信息
        /// </summary>
        /// <returns></returns>
        public PageResult<TaskNode> MobileGetTaskNodeLstByPage(MobileGetTaskNodeLstByPageInput input)
        {
            var apiService = new TradeAuditWebApiService();
            string response = apiService.MobileGetTaskNodeLstByPage(input);

            //todo 测试,后续取消上面注释
            //string response =
            //    "{\"Msg\":\"成功\",\"Status_code\":1,\"Data\":{\"rt\":{\"RE\":{\"RC\":\"0\",\"RM\":\"31\"},\"ROW\":[{\"TID\":\"6524918\",\"NID\":\"6524920\",\"GR\":\"6524920,Apptest\",\"ID\":\"563444\",\"ISCCROLE\":\"False\",\"TY\":\"质押式正回购\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-24\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"111000\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"上交所\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"回购利率\",\"#text\":\"2.00%\"},{\"NAME\":\"回购金额(万)\",\"#text\":\"20\"},{\"NAME\":\"期限\",\"#text\":\"4日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-06-24\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"4\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-06-28\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"应计利息(元)\",\"#text\":\"10.96\"},{\"NAME\":\"到期金额(元)\",\"#text\":\"200,010.96\"},{\"NAME\":\"质押券中债估值\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524912\",\"NID\":\"6524913\",\"GR\":\"6524913,Apptest\",\"ID\":\"563480\",\"ISCCROLE\":\"False\",\"TY\":\"卖出\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-12\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"宝钢多元年金长江养老\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"债券\",\"#text\":\"19宁夏债04\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"10\"},{\"NAME\":\"债券外部评级\",\"#text\":\"AAA\"},{\"NAME\":\"到期收益率\",\"#text\":\"3.4395%\"},{\"NAME\":\"行权收益率\"},{\"NAME\":\"估值偏离度\",\"#text\":\"0.6101\"},{\"NAME\":\"估值偏离量\"},{\"NAME\":\"剩余期限\",\"#text\":\"8.79年\"},{\"NAME\":\"清算速度\",\"#text\":\"T+1\"},{\"NAME\":\"净价(元)\",\"#text\":\"100.00\"},{\"NAME\":\"净价成本(元)\",\"#text\":\"0\"},{\"NAME\":\"全价(元)\",\"#text\":\"100.7665\"},{\"NAME\":\"中债估值(元)\",\"#text\":\"99.3936\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524912\",\"NID\":\"6524914\",\"GR\":\"6524914,Apptest\",\"ID\":\"563480\",\"ISCCROLE\":\"False\",\"TY\":\"卖出\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-12\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"宝钢多元年金长江养老\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"债券\",\"#text\":\"19宁夏债04\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"10\"},{\"NAME\":\"债券外部评级\",\"#text\":\"AAA\"},{\"NAME\":\"到期收益率\",\"#text\":\"3.4395%\"},{\"NAME\":\"行权收益率\"},{\"NAME\":\"估值偏离度\",\"#text\":\"0.6101\"},{\"NAME\":\"估值偏离量\"},{\"NAME\":\"剩余期限\",\"#text\":\"8.79年\"},{\"NAME\":\"清算速度\",\"#text\":\"T+1\"},{\"NAME\":\"净价(元)\",\"#text\":\"100.00\"},{\"NAME\":\"净价成本(元)\",\"#text\":\"0\"},{\"NAME\":\"全价(元)\",\"#text\":\"100.7665\"},{\"NAME\":\"中债估值(元)\",\"#text\":\"99.3936\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524906\",\"NID\":\"6524907\",\"GR\":\"6524907,Apptest\",\"ID\":\"563483\",\"ISCCROLE\":\"False\",\"TY\":\"买断式正回购\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-07-29\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"中行国网安徽省电力企业年金南方\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_03\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"标的券中债估值\",\"#text\":\"101.0544\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"标的券中债估值\",\"#text\":\"101.0544\"},{\"NAME\":\"回购利率\",\"#text\":\"2.00%\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"60\"},{\"NAME\":\"期限\",\"#text\":\"5日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-07-29\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"5日\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-08-03\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"首期金额(元)\",\"#text\":\"606,980.05\"},{\"NAME\":\"债券\",\"#text\":\"19宁夏债05\"},{\"NAME\":\"期间利息(元)\",\"#text\":\"-166.59\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524906\",\"NID\":\"6524908\",\"GR\":\"6524908,Apptest\",\"ID\":\"563483\",\"ISCCROLE\":\"False\",\"TY\":\"买断式正回购\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-07-29\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"中行国网安徽省电力企业年金南方\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_03\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"标的券中债估值\",\"#text\":\"101.0544\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"标的券中债估值\",\"#text\":\"101.0544\"},{\"NAME\":\"回购利率\",\"#text\":\"2.00%\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"60\"},{\"NAME\":\"期限\",\"#text\":\"5日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-07-29\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"5日\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-08-03\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"首期金额(元)\",\"#text\":\"606,980.05\"},{\"NAME\":\"债券\",\"#text\":\"19宁夏债05\"},{\"NAME\":\"期间利息(元)\",\"#text\":\"-166.59\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524882\",\"NID\":\"6524883\",\"GR\":\"6524883,Apptest\",\"ID\":\"563481\",\"ISCCROLE\":\"False\",\"TY\":\"质押式正回购\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-12\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"中国对外经济贸易信托汇鑫46号银河证券1期结构化证券投资集合资金信托\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"回购利率\",\"#text\":\"3.00%\"},{\"NAME\":\"回购金额(万)\",\"#text\":\"50\"},{\"NAME\":\"期限\",\"#text\":\"15日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-06-12\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"16\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-06-28\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"应计利息(元)\",\"#text\":\"657.53\"},{\"NAME\":\"到期金额(元)\",\"#text\":\"500,657.53\"},{\"NAME\":\"质押券中债估值\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524882\",\"NID\":\"6524884\",\"GR\":\"6524884,Apptest\",\"ID\":\"563481\",\"ISCCROLE\":\"False\",\"TY\":\"质押式正回购\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-12\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"中国对外经济贸易信托汇鑫46号银河证券1期结构化证券投资集合资金信托\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"回购利率\",\"#text\":\"3.00%\"},{\"NAME\":\"回购金额(万)\",\"#text\":\"50\"},{\"NAME\":\"期限\",\"#text\":\"15日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-06-12\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"16\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-06-28\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"应计利息(元)\",\"#text\":\"657.53\"},{\"NAME\":\"到期金额(元)\",\"#text\":\"500,657.53\"},{\"NAME\":\"质押券中债估值\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524876\",\"NID\":\"6524877\",\"GR\":\"6524877,Apptest\",\"ID\":\"563476\",\"ISCCROLE\":\"False\",\"TY\":\"卖出\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-17\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"华宝兴业双重优选计划\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"上交所\"},{\"NAME\":\"债券\",\"#text\":\"20盐投D1\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"10\"},{\"NAME\":\"债券外部评级\",\"#text\":\"未评级\"},{\"NAME\":\"到期收益率\",\"#text\":\"5.1156%\"},{\"NAME\":\"行权收益率\"},{\"NAME\":\"估值偏离度\"},{\"NAME\":\"估值偏离量\"},{\"NAME\":\"剩余期限\",\"#text\":\"0.76年\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"净价(元)\",\"#text\":\"100.00\"},{\"NAME\":\"净价成本(元)\",\"#text\":\"0\"},{\"NAME\":\"全价(元)\",\"#text\":\"101.2822\"},{\"NAME\":\"中债估值(元)\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524876\",\"NID\":\"6524878\",\"GR\":\"6524878,Apptest\",\"ID\":\"563476\",\"ISCCROLE\":\"False\",\"TY\":\"卖出\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-06-17\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"华宝兴业双重优选计划\"},{\"NAME\":\"内证\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"上交所\"},{\"NAME\":\"债券\",\"#text\":\"20盐投D1\"},{\"NAME\":\"券面金额(万)\",\"#text\":\"10\"},{\"NAME\":\"债券外部评级\",\"#text\":\"未评级\"},{\"NAME\":\"到期收益率\",\"#text\":\"5.1156%\"},{\"NAME\":\"行权收益率\"},{\"NAME\":\"估值偏离度\"},{\"NAME\":\"估值偏离量\"},{\"NAME\":\"剩余期限\",\"#text\":\"0.76年\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"净价(元)\",\"#text\":\"100.00\"},{\"NAME\":\"净价成本(元)\",\"#text\":\"0\"},{\"NAME\":\"全价(元)\",\"#text\":\"101.2822\"},{\"NAME\":\"中债估值(元)\"},{\"NAME\":\"备注\"}]},{\"TID\":\"6524870\",\"NID\":\"6524871\",\"GR\":\"6524871,Apptest\",\"ID\":\"563033\",\"ISCCROLE\":\"False\",\"TY\":\"拆入\",\"CASHDIRECTION\":\"1\",\"OR\":\"2020-05-28\",\"R\":[{\"NAME\":\"交易对手\",\"#text\":\"yrj_nz_02\"},{\"NAME\":\"内证\",\"#text\":\"yrj_nz_01\"},{\"NAME\":\"是否特批\",\"#text\":\"否\"},{\"NAME\":\"交易市场\",\"#text\":\"银行间\"},{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"拆借利率\",\"#text\":\"10.00%\"},{\"NAME\":\"拆借金额(万)\",\"#text\":\"1,000\"},{\"NAME\":\"期限\",\"#text\":\"3日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-05-28\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"6\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-06-03\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"拆借费用(元)\"},{\"NAME\":\"到期金额(元)\",\"#text\":\"10,016,666.67\"},{\"NAME\":\"备注\",\"#text\":\"系统管理员\"}]}]}}}";


            var responseData = WebApiResultModel<TaskNodeLstRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，登入失败");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);
            CheckResponseData(responseData);

            string totalCount = responseData.Data?.RT?.RE?.RM;

            if (string.IsNullOrEmpty(totalCount)) throw new Exception("接口异常，总数量为空");

            if (!CommonHelper.IsDigit(totalCount)) throw new Exception("接口异常，总数量不为数值");

            return new PageResult<TaskNode>(Convert.ToInt32(responseData.Data.RT.RE.RM),responseData.Data.RT.ROW);
        }

        /// <summary>
        /// 获取审核节点树
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string MobileSingleTaskNodeTree(MobileSingleTaskNodeTreeInput input)
        {
            
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            string response = service.MobileSingleTaskNodeTree(input);

            var responseData = WebApiResultModel<SingleTaskNodeTreeRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);

            return response;
        }

        /// <summary>
        /// 7.4查询审批日志
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<TraceLog> MobileSingleTraceLog(MobileSingleTraceLogInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            string response = service.MobileSingleTraceLog(input);

            var responseData = WebApiResultModel<SingleTraceLogRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);

            if (responseData.Data != null && responseData.Data.RT != null && responseData.Data.RT.TL != null)
            {
                responseData.Data.RT.TL = responseData.Data.RT.TL.OrderBy(tl => tl.OT).ToList();
            }
            return responseData.Data.RT.TL;
        }

        /// <summary>
        /// 查询限额检查结果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LimitData MobileSingleLimitresult(MobileSingleLimitresultInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();
            
            string response = service.MobileSingleLimitresult(input);

            var responseData = WebApiResultModel<SingleLimitresultRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);


            return responseData.Data?.RT?.L;
        }

        /// <summary>
        /// 7.7查询单笔交易详情
        /// </summary>
        /// <returns></returns>
        public Row MobileSingleTradeDetailNew(MobileSingleTradeDetailNewInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            string response = service.MobileSingleTradeDetailNew(input);

            //todo 测试后续上面的取消注释
            //string response =
            //    "{\"Msg\":\"成功\",\"Status_code\":1,\"Data\":{\"rt\":{\"RE\":{\"RC\":\"0\",\"RM\":\"查询成功\"},\"ROW\":{\"R\":[{\"NAME\":\"加权利率加点(BP)\",\"#text\":\"0\"},{\"NAME\":\"交易编号\",\"#text\":\"563444\"},{\"NAME\":\"回购利率\",\"#text\":\"2.00%\"},{\"NAME\":\"交易对手\",\"#text\":\"111000\"},{\"NAME\":\"回购金额(万)\",\"#text\":\"20\"},{\"NAME\":\"交易日期\",\"#text\":\"2020-06-24\"},{\"NAME\":\"期限\",\"#text\":\"4日\"},{\"NAME\":\"首期结算日\",\"#text\":\"2020-06-24\"},{\"NAME\":\"交易方向\",\"#text\":\"正回购\"},{\"NAME\":\"占款天数(日)\",\"#text\":\"4\"},{\"NAME\":\"内部证券账户\",\"#text\":\"孙会沅_内部证券_01\"},{\"NAME\":\"到期结算日\",\"#text\":\"2020-06-28\"},{\"NAME\":\"交易市场\",\"#text\":\"上交所\"},{\"NAME\":\"清算速度\",\"#text\":\"T+0\"},{\"NAME\":\"执行市场 \",\"#text\":\"上交所固定收益平台\"},{\"NAME\":\"应计利息(元)\",\"#text\":\"10.96\"},{\"NAME\":\"到期金额(元)\",\"#text\":\"200,010.96\"},{\"NAME\":\"计息基准\",\"#text\":\"A/365\"},{\"NAME\":\"首期结算方式\",\"#text\":\"非担保交收(RTGS)\"},{\"NAME\":\"到期还款金额(大写)\",\"#text\":\"贰拾万零壹拾元零玖角陆分\"},{\"NAME\":\"到期结算方式\",\"#text\":\"非担保交收(RTGS)\"},{\"NAME\":\"备注\"}]}}}}";

            var responseData = WebApiResultModel<SingleTradeDetailNewRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);


            return responseData.Data?.RT?.Row;
        }

        /// <summary>
        /// 7.8批量审批前检查
        /// </summary>
        /// <returns></returns>
        public TradeAuditService.Models.WebApiResult.CheckBeforeActionByNodeId_Batch.Action MobileCheckBeforeActionByNodeId_Batch(MobileCheckBeforeActionByNodeId_BatchInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            string response = service.MobileCheckBeforeActionByNodeId_Batch(input);

            var responseData = WebApiResultModel<CheckBeforeActionByNodeId_BatchRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);


            return responseData.Data?.RT?.Action;
        }

        /// <summary>
        /// 7.9批量审批操作
        /// </summary>
        /// <returns></returns>
        private void MobileApproveTaskByNodeId_Batch(MobileApproveTaskByNodeId_BatchInput input)
        {

            TradeAuditWebApiService service = new TradeAuditWebApiService();

            TradeAuditService.Models.WebApiResult.CheckBeforeActionByNodeId_Batch.Action action = MobileCheckBeforeActionByNodeId_Batch(new MobileCheckBeforeActionByNodeId_BatchInput()
            {
                aDataTypeCurrent = input.aDataTypeCurrent,
                aNodeIds = input.aNodeIds,
                aUserCode = input.aUserCode,
                targetType = input.targetType,
                
            });

            //审核前校验
            if (input.aAction == ((int)AActionEnum.AgreeContinue).ToString())
            {
                if (!action.ISAGREE) throw new TradeAuditService.ApplicationException("流程没有审核的权限");
            }
            else if (input.aAction == ((int)AActionEnum.Refuse).ToString())
            {
                if (!action.ISREJECT) throw new TradeAuditService.ApplicationException("流程没有审核的权限");
            }

            string response = service.MobileApproveTaskByNodeId_Batch(input);
            var responseData = WebApiResultModel<CheckBeforeActionByNodeId_BatchRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);

        }

        /// <summary>
        /// 7.9.1 批量审批拒绝
        /// </summary>
        /// <param name="input"></param>
        public void MobileApproveTaskByNodeId_BatchRefuse(MobileApproveTaskByNodeId_BatchInput input)
        {
            input.aAction = ((int)AActionEnum.Refuse).ToString();

            MobileApproveTaskByNodeId_Batch(input);
        }

        /// <summary>
        /// 7.9.1 批量审批同意
        /// </summary>
        /// <param name="input"></param>
        public void MobileApproveTaskByNodeId_BatchAgree(MobileApproveTaskByNodeId_BatchInput input)
        {
            input.aAction = ((int)AActionEnum.AgreeContinue).ToString();
            MobileApproveTaskByNodeId_Batch(input);
        }

        /// <summary>
        /// 7.10查询审批数据分组信息
        /// </summary>
        /// <param name="input"></param>
        public List<G> MobileGetTaskNodeGroup(MobileGetTaskNodeGroupInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();
 
            string response = service.MobileGetTaskNodeGroup(input);

            var responseData = WebApiResultModel<MobileGetTaskNodeGroupRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);

            return responseData.Data?.RT?.G;
        }

        /// <summary>
        /// 7.6查询交易指标
        /// </summary>
        /// <param name="input"></param>
        public List<TARGETINDEX> MobileSingleTradeTarget(MobileSingleTradeTargetInput input)
        {
            TradeAuditWebApiService service = new TradeAuditWebApiService();

            string response = service.MobileSingleTradeTarget(input);

            var responseData = WebApiResultModel<MobileSingleTradeTargetRT>.CreateInstance(response);

            //if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，接口异常");
            //if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);

            CheckResponseData(responseData);

            return responseData.Data?.RT?.TARGETINDEX;
        }
        /// <summary>
        /// 检验结果是否有效
        /// </summary>
        /// <param name="responseData"></param>
        private void CheckResponseData<T>(WebApiResultModel<T> responseData) where T:RT
        {
            if (responseData == null) throw new TradeAuditService.ApplicationException("未知异常，登入失败");
            if (!responseData.IsSuccess) throw new TradeAuditService.ApplicationException(responseData.Msg);
        }
    }
}
