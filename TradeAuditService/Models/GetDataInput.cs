using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KindeeDataSynchronizationService.Models
{
    /// <summary>
    /// 获得接口数据的input
    /// </summary>
    public class GetDataInput
    {
        /// <summary>
        /// 表名
        /// </summary>
        public virtual string FormId { get; set; }

        /// <summary>
        /// 查询字段,格式--->"key1,key2"
        /// </summary>
        public virtual string FieldKeys { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderString { get; set; }

        /// <summary>
        /// 条件字段,非必录
        /// </summary>
        public string FilterString { get; set; }

        /// <summary>
        /// 返回总行数,非必录
        /// </summary>
        public int TopRowCount { get; set; } 

        /// <summary>
        /// 开始索引,非必录
        /// </summary>
        public int StartRow { get; set; } 

        /// <summary>
        /// 最大行数,最多不能超过2000行,非必录,与RowStart配合使用
        /// </summary>
        public int Limit { get; set; } 
    }

    /// <summary>
    /// 获得接口数据的泛型input
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GetDataInput<T> : GetDataInput
    {
        // 根据传入的实体生成要查询的列，但需要排除本地的id
        public override string FieldKeys
        {
            //get
            //{
                //var properties = CommonHelper.GetPropertyList(typeof(T));
                //if (properties == null || properties.Count <= 0) return string.Empty;
                //properties.RemoveAll(p => p.Name == "Id");
                //return string.Join(',', properties.Select(p => p.Name));
            //}
        }

        /// <summary>
        /// 表名
        /// </summary>
        public override string FormId
        {
            get
            {
                return typeof(T).Name;
            }
        }

    }
}
