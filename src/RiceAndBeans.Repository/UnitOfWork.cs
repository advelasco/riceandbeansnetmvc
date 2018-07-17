namespace RiceAndBeans.Repository
{
    using System;

    public class UnitOfWork : IUnityOfWork, IDisposable
    {
        public RiceAndBeansContext Context { get; set; }

        public UnitOfWork(RiceAndBeansContext context)
        {
            Context = context;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
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
