using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using GoXLR_Utility.NET.Models.Response.Status;

namespace GoXLR_Utility.NET.Tests
{
    public class JsonDeserializeTest
    {
        private readonly string _statusString;
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            Converters = { new JsonStringEnumConverter() },
            WriteIndented = true
        };
        
        public JsonDeserializeTest()
        {
            const string resourceName = "GoXLR_Utility.NET.Tests.EmbeddedResources.Status.json";
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream!);
            _statusString = reader.ReadToEnd();
        }

        [Fact]
        public void DeserializeStatus()
        {
            Status? status = null;
            var exception = Record.Exception(() =>
            {
                status = JsonSerializer.Deserialize<Status>(_statusString, _serializerOptions);
            });

            Assert.Null(exception);
            Assert.NotNull(status);
            Assert.NotNull(status.Config);
            Assert.NotNull(status.Files);
            Assert.NotNull(status.Mixers);
            Assert.NotNull(status.Paths);
        }
    }
}