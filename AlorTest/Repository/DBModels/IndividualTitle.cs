namespace AlorTest.Repository.DBModels;

public class IndividualTitle
{
    public Guid Id { get; set; }
    public Guid IndividualId { get; set; }
    public string Title { get; set; } = null!;
    public Individual Individual { get; set; } = null!;
}
