using CMS.Server.Data;
using CMS.Server.IRepository;
using CMS.Shared.Domain;

namespace CMS.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext? _context;
        private IGenericRepository<Make>? _makes;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);

        public void Dispose()
        {
            if (_context is not null) _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            if (_context is not null) await _context.SaveChangesAsync();
        }
    }
}
