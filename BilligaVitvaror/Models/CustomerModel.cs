using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilligaVitvaror.Models;

namespace BilligaVitvaror.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailAdress { get; set; }
        public Producer Producer { get; set; }


        //Email


    }
}