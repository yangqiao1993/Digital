﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bug.Dto
{
    /// <summary>
    /// 支持分页、排序和过滤的InputDto
    /// </summary>
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public string Filter { get; set; }
    }
}
