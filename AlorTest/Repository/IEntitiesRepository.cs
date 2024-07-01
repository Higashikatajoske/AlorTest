using AlorTest.Model;

namespace AlorTest.Repository;

public interface IEntitiesRepository
{
    Task AddRangeEntities(Model.Entity[] dbEntities);
}
