using AlorTest.Repository.DBModels;

namespace AlorTest.Repository;

public interface IEntitiesRepository
{
    void AddRangeEntities(Entity[] entities);
}
