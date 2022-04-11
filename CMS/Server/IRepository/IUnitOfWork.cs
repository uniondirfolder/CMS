using CMS.Shared.Domain;

namespace CMS.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IGenericRepository<Make> Makes { get; }
        //IGenericRepository<Model> Models { get; set; }
        //IGenericRepository<Vehicle> Venicles { get; set; }
        //IGenericRepository<Make> Makes { get; }
        //IGenericRepository<Make> Makes { get; }
    }
}
