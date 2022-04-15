using System;
using System.Collections.Generic;
using System.Text;

namespace KindeeDataSynchronizationService.Models
{
    public class DataTableColumn
    {
        public string Data { get; set; }

        public string Name { get; set; }

        public bool Searchable { get; set; }

        public bool Orderable { get; set; }

        public string Value { get; set; }

        public bool Regex { get; set; }

    }

    public class DataTableOrder
    {
        public int Column { get; set; }

        public string Name { get; set; }


        /// <summary>
        /// 排序,desc或者asc
        /// </summary>
        public string Dir { get; set; }
    }
}
