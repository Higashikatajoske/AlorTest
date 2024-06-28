using AlorTest.Configure;
using AlorTest.Model;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;

namespace AlorTest.Service;

public class FileService: IFileService
{
    private readonly StorageOptions _storageOptions;

    public FileService(IOptions<StorageOptions> storageOptions)
    {
        _storageOptions = storageOptions.Value;  
    }

    public async Task<string> SaveFile(UploadFileModel fileModel)
    {
        Stream fileModelStream = fileModel.FileMemoryStream;
        if (fileModelStream.CanSeek && fileModelStream.CanRead)
        {
            byte[] memoryBuffer = new byte[fileModelStream.Length];
            fileModelStream.Position = 0;
            await fileModelStream.ReadAsync(memoryBuffer, 0, memoryBuffer.Length);
            string fileName = CreateFileName(fileModel.Extension);
            string filepath = Path.Combine(_storageOptions.FileStoragePath, fileName);

            using (FileStream fileStream = new FileStream(filepath, FileMode.Create))
            {
                fileStream.Write(memoryBuffer, 0, memoryBuffer.Length);
            }
        }
        return string.Empty;
    }

    private string ByteArrayToString(byte[] arrInput)
    {
        StringBuilder sOutput = new StringBuilder(arrInput.Length);
        for (int index = 0; index < arrInput.Length; index++)
        {
            sOutput.Append(arrInput[index].ToString("X2"));
        }
        return sOutput.ToString();
    }

    private string CreateFileName(string fileType)
    {
        string fileName = string.Empty;
        switch(fileType)
        {
            case "text/xml":
                fileName = "XmlFile.xml";
                break;
            default:
                fileName = "File";
                break;
        }
        return fileName;
    }
}
