namespace RiceAndBeans.Repository.Interface
{
    using RiceAndBeans.Model;
    using System;
    using System.Collections.Generic;

    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> GetAll();
        CategoryModel GetById(Guid id);
        void Insert(CategoryModel category);
        void Delete(Guid id);
        void Update(CategoryModel category);
    }
}