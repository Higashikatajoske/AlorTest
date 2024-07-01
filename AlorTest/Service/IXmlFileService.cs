using AlorTest.Model;

namespace AlorTest.Service;

public interface IXmlFileService
{
    Task SaveConsolidatedListToDB(ConsolidatedList consolidatedList);
}
