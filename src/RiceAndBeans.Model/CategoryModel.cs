namespace RiceAndBeans.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public class CategoryModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Enabled { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Tags { get; set; }

        [ForeignKey("Parent")]
        public Guid? ParentCategoryId { get; set; }

        public virtual CategoryModel Parent { get; set; }

        public virtual ICollection<CategoryModel> Children { get; set; }
    }
}
