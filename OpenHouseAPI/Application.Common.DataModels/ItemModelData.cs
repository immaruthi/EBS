using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DataModels
{
    public class ItemModelData
    {
        public string ItemDescription { get; set; }
        public ItemMaster ItemType { get; set; }
        public Double ItemPrice { get; set; }
    }
}
