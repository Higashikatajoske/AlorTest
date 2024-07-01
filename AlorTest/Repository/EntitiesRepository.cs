using AlorTest.Model;

namespace AlorTest.Repository;

public class EntitiesRepository: IEntitiesRepository
{
    private readonly TestContext _dbContext;
    public EntitiesRepository(TestContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddRangeEntities(Entity[] entities)
    {
        List<DBModels.Entity> dbEntities = new List<DBModels.Entity>();

        foreach (Entity entity in entities)
        {
            DBModels.Entity dbEntity = new DBModels.Entity()
            {
                Id = Guid.NewGuid(),
                DataId = int.Parse(entity.DataId),
                VersionNum = int.Parse(entity.VersionNum),
                FirstName = entity.FirstName,
                UnListType = entity.UnListType,
                ReferenceNumber = entity.ReferenceNumber,
                ListedOn = entity.ListedOn,
                NameOriginalScript = entity.NameOriginalScript,
                Comments1 = entity.Comments1,
                SortKey = entity.SortKey,
                SortKeyLastMod = entity.SortKeyLastMod,
            };
            dbEntities.Add(dbEntity);
        }
        await _dbContext.Entities.AddRangeAsync(dbEntities);
        _dbContext.SaveChanges();
    }
}
