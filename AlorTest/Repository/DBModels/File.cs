using System;
using System.Collections.Generic;

namespace AlorTest.Repository.DBModels;

public partial class File
{
    public int Id { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileType { get; set; }
}
