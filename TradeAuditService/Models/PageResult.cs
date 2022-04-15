using System;
using System.Collections.Generic;
using System.Text;

namespace KindeeDataSynchronizationService.Models
{
    public class PageResult<T> where T:new ()
    {
        public PageResult(int totalCount,List<T> list)
        {
            //Draw = input.Draw;
            RecordsTotal = totalCount;
            Data = list ?? new List<T>();
            //RecordsFiltered = Data.Count;
            RecordsFiltered = totalCount;
        }

        public int Draw { get; set; }


        public  int RecordsTotal { get; set; }

        public List<T> Data { get; set; }

        public int RecordsFiltered { get; set; }

    }
}
