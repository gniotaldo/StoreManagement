using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreManagement.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public string ImageUrl { get; set; }
    }
}