using Microsoft.EntityFrameworkCore;

using SalesWebMvc.Dominio;

namespace SalesWebMvc.Infra.Data
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
