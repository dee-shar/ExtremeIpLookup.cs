# ExtremeIpLookup.cs
Web-API for [extreme-ip-lookup.com](https://extreme-ip-lookup.com/) an API that provides ability to get all geolocation information about an IP address

## Example
```cs
using ExtremeIpLookupApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ExtremeIpLookup();
            string ipInfo = await api.GetMyIp();
            Console.WriteLine(ipInfo);
        }
    }
}
```
