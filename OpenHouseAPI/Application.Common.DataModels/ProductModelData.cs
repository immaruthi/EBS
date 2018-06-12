﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DataModels
{
    public class ProductModelData
    {
        public ProductMaster ProductType { get; set; }

        public List<ItemModelData> ProductItems { get; set; }
    }
}
