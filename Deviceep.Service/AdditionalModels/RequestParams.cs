using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.Service.AdditionalModels
{
    public class RequestParams
    {
        const int maxPageSize = 50;

        public int PageNnumber { get; set; } = 1;
        private int _pageSize = 30;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
