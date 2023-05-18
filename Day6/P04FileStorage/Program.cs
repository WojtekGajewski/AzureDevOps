using Azure;
using Azure.Storage.Files;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

//using Microsoft.WindowsAzure.Storage - for using bmp or large files

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsawg;AccountKey=lA979+RwVRM3YnxT7Sg8yeJgHYKx2HxEu94cHjq44KzwsdXC55lpszfwZ9WldmZDrjJSkaBUPlbJ+ASt99h50w==;EndpointSuffix=core.windows.net";
//var containerName = "volleyballpictures";

var shareName = "pictures";

ShareServiceClient shareServiceClient = new ShareServiceClient(connectionString);
ShareClient shareClient = shareServiceClient.GetShareClient(shareName);
ShareDirectoryClient directoryClient = shareClient.GetRootDirectoryClient();
Console.WriteLine("Enter the file path of the image to upload:");
var imagePath = Console.ReadLine();
using var fileStream = File.OpenRead(imagePath);
var fileName = Path.GetFileName(imagePath);
ShareFileClient fileClient = directoryClient.GetFileClient(fileName);
await fileClient.CreateAsync(fileStream.Length);
await fileClient.UploadRangeAsync(new Azure.HttpRange(0, fileStream.Length), fileStream);

Console.WriteLine($"Image '{imagePath}' uploaded successfully to the File Share.");
Console.WriteLine("Enter the name of the image to download from the File Share:");
var imageNameToDownload = Console.ReadLine();
var downloadFileClient = directoryClient.GetFileClient(imageNameToDownload);
Console.WriteLine("Enter the destination file path to save the downloaded image:");
var destinationPath = Console.ReadLine();
ShareFileDownloadInfo download = await downloadFileClient.DownloadAsync();
using var downloadFileStream = File.OpenWrite(destinationPath);
await download.Content.CopyToAsync(downloadFileStream);
downloadFileStream.Close();
Console.WriteLine($"Image '{imageNameToDownload}' downloaded successfully from the File Share and saved to '{destinationPath}'.");