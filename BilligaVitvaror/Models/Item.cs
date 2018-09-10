using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilligaVitvaror.Models;

namespace BilligaVitvaror.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        public int CategoryId { get; set; }
        public String TitleName { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
    }

    // Order/

}