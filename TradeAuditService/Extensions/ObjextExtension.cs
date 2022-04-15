using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TradeAuditService.Extensions
{
    public static class ObjextExtension
    {
        /// <summary>
        /// 仅支持简单的相同实体转换
        /// </summary>
        public static T MapTo<T>(this object obj,object tObj = null, List<string> ignores = null)
        {
            if (obj == null) return default(T);

            var tProperties = typeof(T).GetProperties().ToList();
            var sProperties = obj.GetType().GetProperties().ToList();

            if(tObj == null)
            {
                tObj = Assembly.GetExecutingAssembly().CreateInstance(typeof(T).FullName);
            }

            for (int i = 0; i < sProperties.Count; i++)
            {
                if (ignores != null && ignores.Count >= 0)
                {
                    if (ignores.Exists(ig => ig == sProperties[i].Name)) continue;
                }
                var sPro = sProperties[i];
                var tPro = tProperties.Where(a => a.Name.ToLower() == sPro.Name.ToLower()).FirstOrDefault();
                if (tPro == null) continue;
                tPro.SetValue(tObj, sPro.GetValue(obj));

            }
            return (T)tObj;
        }

    }

}
