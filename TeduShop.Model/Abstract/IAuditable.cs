﻿using System;

namespace TeduShop.Model.Abstract
{
    internal interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}