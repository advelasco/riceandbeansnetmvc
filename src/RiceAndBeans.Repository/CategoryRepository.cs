namespace RiceAndBeans.Repository
{
    using RiceAndBeans.Model;
    using RiceAndBeans.Repository.Interface;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private readonly RiceAndBeansContext context;

        public CategoryRepository(IUnityOfWork unityOfWork)
        {
            this.context = unityOfWork.Context;
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            return context.Categories.Where(u => u.Enabled).ToList();
        }

        public CategoryModel GetById(Guid id)
        {
            return context.Categories.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(CategoryModel category)
        {
            context.Categories.Add(category);
        }

        public void Delete(Guid id)
        {
            CategoryModel category = context.Categories.FirstOrDefault(u => u.Id == id);

            if (category != null)
            {
                category.Enabled = false;

                Update(category);
            }
        }

        public void Update(CategoryModel category)
        {
            context.Entry(category).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
