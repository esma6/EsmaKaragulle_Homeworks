﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Paging
{
    public class PagingParameters
    {
        const int maxPageSize = 100;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
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
