using AlorTest.Model;

namespace AlorTest.Repository;

public interface IIndividualsRepository
{
    Task AddRangeIndividuals(Individual[] individualsArray);
}
