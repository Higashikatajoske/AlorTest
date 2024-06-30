using AlorTest.Configure;
using AlorTest.Model;
using AlorTest.Repository.DBModels;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;

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
                FileType = GetFileExtension(uploadFileModel.Extension)
            };
        }
        return file;
    }

    private string GetHashFile(byte[] fileBytes)
    {
        byte[] hashValue = MD5.HashData(fileBytes);
        return Convert.ToHexString(hashValue);
    }

    public FileStream? GetFile(string fileName)
    {
        try
        {
            string filepath = Path.Combine(_storageOptions.FileStoragePath, fileName);
            FileStream fileStream = new FileStream(filepath, FileMode.Open);
            fileStream.Position = 0;
            return fileStream;
        }
        catch
        {
            return null;
        }
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

    private string GetFileExtension(string contentType)
    {
        string extension;
        switch (contentType)
        {
            case "text/xml":
                extension = "xml";
                break;
            default:
                extension = string.Empty;
                break;
        }
        return extension;
    }
}
