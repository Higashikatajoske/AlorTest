
using AlorTest.Model;
using AlorTest.Repository.DBModels;

namespace AlorTest.Repository
{
    public class IndividualsRepository: IIndividualsRepository
    {
        private readonly TestContext _context;
        public IndividualsRepository(TestContext dbContext) 
        {
            _context = dbContext;
        }

        public void AddRangeIndividuals(Model.Individual[] individualsArray)
        {

        } 
    }
}
