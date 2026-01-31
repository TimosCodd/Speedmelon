using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;

namespace Speedmelon.util
{
    internal static class DownloadManager
    {
        private static readonly HttpClient _client = new HttpClient();
        public static async Task InstallPackage(string url, string destinationFolder, IProgress<string> progress)
        {
            try
            {
                string tempFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".zip");

                progress.Report("Downloading: " + Path.GetFileName(url));
                byte[] data = await _client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(tempFile, data);

                progress.Report("Extracting");
                Directory.CreateDirectory(destinationFolder);
                ZipFile.ExtractToDirectory(tempFile, destinationFolder, true);

                if (File.Exists(tempFile)) File.Delete(tempFile);

                progress.Report("Done downloading " + Path.GetFileName(url));
            }
            catch (Exception ex)
            {
                throw new Exception("Exception: from " + url + " | " + ex.Message);
            }
        }
    }
}