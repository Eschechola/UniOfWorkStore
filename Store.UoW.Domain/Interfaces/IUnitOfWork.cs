namespace Store.UoW.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
