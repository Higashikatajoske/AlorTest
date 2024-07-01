using AlorTest.Repository.DBModels;

namespace AlorTest.Repository;

public class EntitiesRepository: IEntitiesRepository
{
    private readonly TestContext _dbContext;
    public EntitiesRepository(TestContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddRangeEntities(Entity[] entities)
    {

    }
}
