﻿namespace AlorTest.Model;

public class UploadFileModel
{
    public string FileName { get; set; } = null!;
    public string Extension { get; set; } = null!;
    public Stream FileStreamContent { get; set; } = null!;
}
