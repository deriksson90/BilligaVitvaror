using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BilligaVitvaror.Models
{
    public class OrderContext : DbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Category> Categories { get; set; }

    }
}