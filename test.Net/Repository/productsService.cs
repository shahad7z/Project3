using System;
using System.Threading.Tasks;
using test.Net.Models;

namespace test.Net.Repository
{
    public class productsService : IproductsService , IDisposable
    {
        AppDbContext _context;

        public productsService(AppDbContext appDbContext)
        {
            _context = appDbContext ?? throw new
                ArgumentNullException(nameof(appDbContext));

        }

        public productsService()
        {
        }

        public void Addcostumer(customer customertoadd)
        {
            _context.customers.Add(customertoadd);
        }

        public void GetIndex()
        {
          
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }

        }




    }
}
