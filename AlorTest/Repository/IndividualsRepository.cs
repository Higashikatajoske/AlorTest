
using AlorTest.Model;
using AlorTest.Repository.DBModels;

namespace AlorTest.Repository
{
    public class IndividualsRepository: IIndividualsRepository
    {
        private readonly TestContext _dbContext;
        public IndividualsRepository(TestContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task AddRangeIndividuals(Model.Individual[] individualsArray)
        {
            List<DBModels.Individual> dbIndividualList = new List<DBModels.Individual>();

            foreach (Model.Individual individual in individualsArray)
            {
                DBModels.Individual dbIndividual = new DBModels.Individual()
                {
                    DataId = int.Parse(individual.DataId),
                    VersionNum = int.Parse(individual.VersionNum),
                    FirstName = individual.FirstName,
                    SecondName = individual.SecondName,
                    ThirdName = individual.ThirdName,
                    FourthName = individual.FourthName,
                    UnListType = individual.UnListType,
                    ReferenceNumber = individual.ReferenceNumber,
                    ListedOn = individual.ListedOn,
                    Gender = individual.Gender,
                    NameOriginalScript = individual.NameOriginalScript,
                    Comments1 = individual.Comments1,
                    SortKey = individual.SortKey,
                    SortKeyLastMod = individual.SortKeyLastMod,
                };
                dbIndividualList.Add(dbIndividual);
            }
            await _dbContext.AddRangeAsync(dbIndividualList);
            _dbContext.SaveChanges();
        } 
    }
}
