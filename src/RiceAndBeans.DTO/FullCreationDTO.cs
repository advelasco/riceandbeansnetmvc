using System;

namespace RiceAndBeans.DTO
{
    public class FullCreationDTO
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tags { get; set; }

        public Guid ParentCategoryId { get; set; }
    }
}
