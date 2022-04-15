using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TradeAuditService.Helper
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class EnumExtension
    {
        public static string GetDescription(this Enum @enum)
        {
            return @enum.GetType()
            .GetMember(@enum.ToString())
            .FirstOrDefault()?
            .GetCustomAttribute<DescriptionAttribute>()?
            .Description;
        }
    }
}
