
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
            List<IndividualTitle> dbIndividualTitleList = new List<IndividualTitle>();
            List<IndividualDesignation> dbIndividualDesignationList = new List<IndividualDesignation>();

            foreach (Model.Individual individual in individualsArray)
            {
                DBModels.Individual dbIndividual = new DBModels.Individual()
                {
                    Id = Guid.NewGuid(),
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

                if (individual.Title != null)
                {
                    foreach (Value title in individual.Title)
                    {
                        IndividualTitle dbIndividualTitle = new IndividualTitle()
                        {
                            Title = title.ValueField,
                            IndividualId = dbIndividual.Id
                        };

                        dbIndividualTitleList.Add(dbIndividualTitle);
                    }
                }

                if (individual.Designation != null)
                {
                    foreach (Value designation in individual.Designation)
                    {
                        IndividualDesignation dbIndividualDesignation = new IndividualDesignation()
                        {
                           Description = designation.ValueField,
                           IndividualId = dbIndividual.Id
                        };

                        dbIndividualDesignationList.Add(dbIndividualDesignation);
                    }
                }
            }
            await _dbContext.AddRangeAsync(dbIndividualList);
            await _dbContext.AddRangeAsync(dbIndividualTitleList);
            await _dbContext.AddRangeAsync(dbIndividualDesignationList);
            _dbContext.SaveChanges();
        } 
    }
}
