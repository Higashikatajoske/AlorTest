namespace AlorTest.Repository.DBModels;

public class Individual
{
    public Guid Id { get; set; }
    public int DataId { get; set; }
    public int VersionNum { get; set; }
    public string FirstName { get; set; } = null!;
    public string? SecondName { get; set; } = null!;
    public string? ThirdName { get; set; } = null!;
    public string? FourthName { get; set; } = null!;
    public string? UnListType { get; set; } = null!;
    public string? ReferenceNumber { get; set; } = null!;
    public string? ListedOn { get; set; } = null!;
    public string? Gender { get; set; } = null!;
    public string? NameOriginalScript { get; set; } = null!;
    public string? Comments1 { get; set; } = null!;
    public string? SortKey { get; set; } = null!;
    public string? SortKeyLastMod { get; set; } = null!;

    public List<IndividualTitle> Titles { get; set; } = new List<IndividualTitle>();
    public List<IndividualDesignation> Designations { get; set; } = new List<IndividualDesignation>();
}
