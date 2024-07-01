namespace AlorTest.Repository.DBModels;

public class Entity
{
    public Guid Id { get; set; }
    public int DataId { get; set; }
    public int VersionNum { get; set; }
    public string FirstName { get; set; } = null!;
    public string UnListType{ get; set; } = null!;
    public string ReferenceNumber { get; set; } = null!;
    public string ListedOn { get; set; } = null!;
    public string NameOriginalScript { get; set; } = null!;
    public string Comments1 { get; set; } = null!;
    public string SortKey { get; set; } = null!;
    public string SortKeyLastMod { get; set; } = null!;
}
