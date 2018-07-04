namespace StroreOfBuild.Domain
{
    public interface IRepository<TEntity>
    {
         TEntity GetbyId(int id);
         void Save(TEntity entity);
    }
}