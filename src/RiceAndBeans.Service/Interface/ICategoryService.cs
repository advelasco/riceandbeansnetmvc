namespace RiceAndBeans.Service.Interface
{
    using RiceAndBeans.DTO;
    using System.Collections.Generic;

    public interface ICategoryService
    {
        IEnumerable<QuickViewDTO> GetAll();
        void QuickInsert(QuickCreationDTO quickCategory);
    }
}