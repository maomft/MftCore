using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingdeeDataSynchronizationWebMvc.Models
{
    public abstract class PageModel
    {
        /// <summary>
        /// 绘制计数器。这个是用来确保Ajax从服务器返回的是对应的（Ajax是异步的，因此返回的顺序是不确定的）。 要求在服务器接收到此参数后再返回
        /// </summary>
        public int Draw { get; set; }

        /// <summary>
        /// 第一条数据的起始位置，比如0代表第一条数据
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// 告诉服务器每页显示的条数，这个数字会等于返回的 data集合的记录数，可能会大于因为服务器可能没有那么多数据。这个也可能是-1，代表需要返回全部数据(尽管这个和服务器处理的理念有点违背)
        /// </summary>
        public int Length { get; set; }

        public int PageIndex
        {
            get
            {
                if (Length == 0) return 0;
                int pageIndex = (int) (Start / Length) + 1;
                return pageIndex;
            }
            set { }
        }
    }
}
