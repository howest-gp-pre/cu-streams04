using System.Net;
using Newtonsoft.Json;
using Pre.Streams.Cursus04.Core;

namespace Pre.Streams.Cursus04.Cons;

public class App
{
    public void Run()
    {
        List<PostalCode> postalCodes;
        var json = new WebClient().DownloadString(
            "https://raw.githubusercontent.com/jief/zipcode-belgium/master/zipcode-belgium.json");
        postalCodes = JsonConvert.DeserializeObject<List<PostalCode>>(json);
        foreach (var postalCode in postalCodes)
        {
            Console.WriteLine(postalCode);
        }
    }
}