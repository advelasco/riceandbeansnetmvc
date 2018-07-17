namespace RiceAndBeans.Repository
{
    /// <summary>
    /// About UnitOfWork
    /// </summary>
    public interface IUnityOfWork
    {
        RiceAndBeansContext Context { get; set; }

        void Save();
    }
}
