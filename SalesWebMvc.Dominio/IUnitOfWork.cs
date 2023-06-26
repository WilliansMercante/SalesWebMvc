namespace SalesWebMvc.Dominio
{
    public interface IUnitOfWork<TContext> where TContext : class
    {
        void Commit();
    }
}
