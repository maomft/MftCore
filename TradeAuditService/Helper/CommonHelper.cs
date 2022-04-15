using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAuditService.Helper
{
    /// <summary>
    /// 帮助类
    /// </summary>
    public class CommonHelper
    {
        public static bool IsDigit(object obj)
        {
            try
            {
                Convert.ToInt32(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
