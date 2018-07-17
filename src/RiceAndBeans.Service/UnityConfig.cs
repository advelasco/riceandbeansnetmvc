namespace RiceAndBeans.Service
{
    using RiceAndBeans.Service.Interface;
    using Unity;

    public class UnityConfig
    {
        public static IUnityContainer Register(IUnityContainer container)
        {
            RiceAndBeans.Repository.UnityConfig.Register(container);

            container.RegisterType<ICategoryService, CategoryService>();

            return container;
        }
    }
}
