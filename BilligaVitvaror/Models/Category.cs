using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilligaVitvaror.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Item> Items { get; set; }
    }
}