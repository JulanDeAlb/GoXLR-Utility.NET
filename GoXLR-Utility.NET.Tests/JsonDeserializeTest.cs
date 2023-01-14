using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status;

namespace GoXLR_Utility.NET.Tests
{
    public class JsonDeserializeTest
    {
        public string StatusString;
        public Status? Status;
        public JsonSerializerOptions SerializerOptions = new() { Converters = { new JsonStringEnumConverter() }};
        
        public JsonDeserializeTest()
        {
            const string resourceName = "GoXLR_Utility.NET.Tests.EmbeddedResources.Status.json";
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream!);
            StatusString = reader.ReadToEnd();
        }

        [Fact]
        public void DeserializeStatus()
        {
            var exception = Record.Exception(() =>
            {
                Status = JsonSerializer.Deserialize<Status>(StatusString);
            });
            
            Assert.Null(exception);
        }

        [Fact]
        public void CheckForNullStatus()
        {
            Assert.NotNull(Status);
            
            Assert.NotNull(Status.Config);
            Console.WriteLine(Status.Config.AutostartEnabled);
            Console.WriteLine(Status.Config.DaemonVersion);
            Console.WriteLine(Status.Config.ShowTrayIcon);
        }
    }
}