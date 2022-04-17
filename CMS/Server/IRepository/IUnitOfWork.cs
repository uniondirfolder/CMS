using CMS.Shared.Domain;

namespace CMS.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Venicles { get; }
        IGenericRepository<Colour> Colours { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
