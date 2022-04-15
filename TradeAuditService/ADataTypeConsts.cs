using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService
{
    /// <summary>
    /// aDataType数据类型
    /// </summary>
    public class ADataTypeConsts
    {
        /// <summary>
        /// 待审核
        /// </summary>
        public const int WaitAudit = 0;

        /// <summary>
        /// 待会签
        /// </summary>
        public const int Countersign = 1;

        /// <summary>
        /// 提前审核
        /// </summary>
        public const int PreAudit  = 2;

        /// <summary>
        /// 补审批
        /// </summary>
        public const int AddAudit = 3;

        /// <summary>
        /// 已审核
        /// </summary>
        public const int Audited = 4;

        /// <summary>
        /// 已会签
        /// </summary>
        public const int Countersigned = 5;

        /// <summary>
        /// 等待签核
        /// </summary>
        public const int WaitingSign = 6;

        /// <summary>
        /// 已签核
        /// </summary>
        public const int Signed = 7;

        /// <summary>
        /// 
        /// </summary>
        //public const int  = 8;

        /// <summary>
        /// 我的提交
        /// </summary>
        public const int MySubmit = 9;


    }
}
