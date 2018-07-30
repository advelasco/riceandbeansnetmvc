using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RiceAndBeans.UI.ViewModel
{
    public class FullCategoryViewModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tags { get; set; }

        public Guid ParentCategoryId { get; set; }
    }
}