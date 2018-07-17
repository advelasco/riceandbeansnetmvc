namespace RiceAndBeans.Repository
{
    using RiceAndBeans.Repository.Interface;
    using Unity;
    using Unity.Lifetime;

    public class UnityConfig
    {
        public static IUnityContainer Register(IUnityContainer container)
        {
            container.RegisterType<RiceAndBeansContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnityOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            return container;
        }
    }
}