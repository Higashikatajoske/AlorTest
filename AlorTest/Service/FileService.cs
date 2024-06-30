using AlorTest.Configure;
using AlorTest.Model;
using AlorTest.Repository.DBModels;
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

    public async Task<DownloadedFile?> SaveFile(UploadFileModel uploadFileModel)
    {
        DownloadedFile? file = null;
        Stream fileModelStream = uploadFileModel.FileMemoryStream;
        if (fileModelStream.CanSeek && fileModelStream.CanRead)
        {
            byte[] memoryBuffer = new byte[fileModelStream.Length];
            fileModelStream.Position = 0;
            await fileModelStream.ReadAsync(memoryBuffer, 0, memoryBuffer.Length);
            string fileHash = GetHashFile(memoryBuffer);
            string fileName = CreateFileName(fileHash, uploadFileModel.Extension);
            string filepath = Path.Combine(_storageOptions.FileStoragePath, fileName);

            using (FileStream fileStream = new FileStream(filepath, FileMode.Create))
            {
                fileStream.Write(memoryBuffer, 0, memoryBuffer.Length);
            }

            file = new DownloadedFile()
            {
                FileName = fileName,
                FileType = uploadFileModel.Extension
            };
        }
        return file;
    }

    private string GetHashFile(byte[] fileBytes)
    {
        byte[] hashValue = MD5.HashData(fileBytes);
        return Convert.ToHexString(hashValue);
    }

    public async Task<MemoryStream?> GetFile(string fileName)
    {
        MemoryStream memoryStream = new MemoryStream();
        string filepath = Path.Combine(_storageOptions.FileStoragePath, fileName);
        using (FileStream fileStream = new FileStream(filepath, FileMode.Open))
        {
            await fileStream.CopyToAsync(memoryStream);
            memoryStream.Position = 0;
        }
        return memoryStream;
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

    private string CreateFileName(string fileHash, string fileType)
    {
        string fileName;
        switch(fileType)
        {
            case "text/xml":
                fileName = fileHash + "XmlFile.xml";
                break;
            default:
                fileName = "File";
                break;
        }
        return fileName;
    }
}
