using AlorTest.Model;
using AlorTest.Repository;

namespace AlorTest.Service;

public class XmlFileService: IXmlFileService
{
    private readonly IEntitiesRepository _entitiesRepository;
    private readonly IIndividualsRepository _individualsRepository;
    public XmlFileService(
        IEntitiesRepository entitiesRepository, 
        IIndividualsRepository individualsRepository) 
    {
        _entitiesRepository = entitiesRepository;
        _individualsRepository = individualsRepository;
    }

    public async Task SaveConsolidatedListToDB(ConsolidatedList consolidatedList)
    {
        await _entitiesRepository.AddRangeEntities(consolidatedList.EntitiesList);
        await _individualsRepository.AddRangeIndividuals(consolidatedList.IndividualsList);
    }
}
