namespace AlorTest.Repository.DBModels;

public class IndividualDesignation
{
    public Guid IndividualId { get; set; }
    public string Description { get; set; } = null!;
    public Individual Individual { get; set; } = null!;
}
