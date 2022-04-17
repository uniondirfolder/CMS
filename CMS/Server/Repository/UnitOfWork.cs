using CMS.Server.Data;
using CMS.Server.IRepository;
using CMS.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext? _context;
        private IGenericRepository<Make>? _makes;
        private IGenericRepository<Model>? _models;
        private IGenericRepository<Vehicle>? _vehicles;
        private IGenericRepository<Colour>? _colours;
        private IGenericRepository<Booking>? _bookings;
        private IGenericRepository<Customer>? _customers;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);

        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Vehicle> Venicles => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public IGenericRepository<Colour> Colours => _colours ??= new GenericRepository<Colour>(_context);

        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public void Dispose()
        {
            if (_context is not null) _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            // NOT WORK - states not be changed 
            //var user = httpContext.User.Identity.Name;

            //var entries = _context.ChangeTracker.Entries()
            //    .Where(q => q.State == EntityState.Modified ||
            //    q.State == EntityState.Added);

            //foreach (var entry in entries)
            //{
            //    ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
            //    ((BaseDomainModel)entry.Entity).UpdatedBy = user;

            //    if (entry.State == EntityState.Added)
            //    {
            //        ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
            //        ((BaseDomainModel)entry.Entity).CreatedBy = user;
            //    }


            //}


            await _context.SaveChangesAsync();
        }
    }
}
