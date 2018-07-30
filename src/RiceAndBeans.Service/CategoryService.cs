﻿namespace RiceAndBeans.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using RiceAndBeans.DTO;
    using RiceAndBeans.Repository;
    using RiceAndBeans.Repository.Interface;
    using RiceAndBeans.Service.Interface;

    public class CategoryService  : ICategoryService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IUnityOfWork unityOfWork, ICategoryRepository categoryRepository)
        {
            _unityOfWork = unityOfWork;
            _categoryRepository = categoryRepository;
        }

        public void FullInsert(FullCreationDTO fullCategory)
        {
            _categoryRepository.Insert(new Model.CategoryModel
            {
                Id = System.Guid.NewGuid(),
                Name = fullCategory.Name,
                LongDescription = fullCategory.LongDescription,
                ShortDescription = fullCategory.ShortDescription,
                ParentCategoryId = fullCategory.ParentCategoryId,
                Enabled = true
            });

            _unityOfWork.Save();
        }

        public IEnumerable<QuickViewDTO> GetAll()
        {
            return _categoryRepository.GetAll()?.ToList().Select(m => new QuickViewDTO { Id = m.Id, Name = m.Name, Parent = m.Parent?.Name });
        }

        public void QuickInsert(QuickCreationDTO quickCategory)
        {
            _categoryRepository.Insert(new Model.CategoryModel { Id = System.Guid.NewGuid(),
                Name = quickCategory.CategoryName,
                Enabled = quickCategory.Enabled });
            
            _unityOfWork.Save();
        }
    }
}
