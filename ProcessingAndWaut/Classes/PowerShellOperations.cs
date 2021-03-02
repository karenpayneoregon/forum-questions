using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProcessingAndWait.LanguageExtensions;

namespace ProcessingAndWait.Classes
{
    /// <summary>
    /// Code samples using Process.Start rather than using
    /// the NuGet package
    /// </summary>
    /// <remarks>
    /// Requires .NET 5 or .NET Core
    /// </remarks>
    public class PowerShellOperations
    {
        /// <summary>
        /// Get this computer's IP address 
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetIpAddress()
        {
            const string fileName = "ipPower.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "Invoke-RestMethod ipinfo.io/ip",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;

            process.EnableRaisingEvents = true;

            var ipAddressResult = reader.ReadToEnd();

            await File.WriteAllTextAsync(fileName, ipAddressResult);
            await process.WaitForExitAsync();

            return await File.ReadAllTextAsync(fileName);
        }
        public static async Task<string> GetIpAddresses()
        {
            const string fileName = "ipAllPower.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "Get-NetIPAddress | ConvertTo-Json",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;

            process.EnableRaisingEvents = true;

            var ipAddressResult = reader.ReadToEnd();

            await File.WriteAllTextAsync(fileName, ipAddressResult);
            await process.WaitForExitAsync();

            return await File.ReadAllTextAsync(fileName);
        }

        public static async Task<List<ServiceItem>> GetServicesAsJson()
        {
            const string fileName = "services.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "Get-Service | Select-Object Name, DisplayName, @{ n='Status'; e={ $_.Status.ToString() } }, @{ n='table'; e={ 'Status' } } | ConvertTo-Json",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;

            process.EnableRaisingEvents = true;

            var fileContents = await reader.ReadToEndAsync();

            await File.WriteAllTextAsync(fileName, fileContents);
            await process.WaitForExitAsync();
            
            var json = await File.ReadAllTextAsync(fileName);

            return JsonSerializer.Deserialize<List<ServiceItem>>(json);

        }
        /// <summary>
        /// Get all services using ServiceController class, not PowerShell
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public static List<ServiceItem> GetServicesConcrete(string serviceName)
        {

            var serviceItems = ServiceController.GetServices().Select(service => new ServiceItem()
            {
                Name = service.ServiceName,
                DisplayName = service.DisplayName,
                ServiceStartMode = service.StartType
            }).ToList();
            
            return serviceItems;
        }
    }
}
