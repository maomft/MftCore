using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAuditService.Models.WebApiResult;

namespace TradeAuditService.Models
{
    /// <summary>
    /// webapi返回的接口数据模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WebApiResultModel<T> where T:RT
    {
        /// <summary>
        /// 应答说明，登录时：成功 返回登录用户名，失败返回失败原因 其他：成功数量，失败返回失败原因
        /// </summary>
        public string Msg
        {
            get
            {
                return Data?.RT?.RE?.RM;
            }
        }

        /// <summary>
        /// 应答情况,1成功  其他为失败
        /// </summary>
        public string Status_code { get; set; }

        public bool IsSuccess
        {
            get
            {
                bool isSuccess = true;
                //if (Status_code != "1") isSuccess = false;
                if (Data.RT.RE.RC != "0") isSuccess = false;//逻辑调整，需要内存的状态码
                return isSuccess;

            }
        }

        public WebApiResultData<T> Data { get; set; }

        /// <summary>
        /// 根据webapi请求的结果生成model
        /// </summary>
        /// <param name="responseData">webapi接口请求返回的数据</param>
        public static WebApiResultModel<T> CreateInstance(string responseData)
        {
            var obj = (WebApiResultModel<T>)JsonConvert.DeserializeObject(responseData,typeof(WebApiResultModel<T>));

            return obj;
        }

    }
    
}
