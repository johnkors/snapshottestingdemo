using Microsoft.AspNetCore.Mvc.Testing;
using Snapshooter.Xunit;
namespace api.tests;

public class UnitTest1
{
    private HttpClient _client;

    public UnitTest1()
    {
        var factory = new WebApplicationFactory<Program>();
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsPersonJson()
    {
        var jsonPerson = await _client.GetStringAsync("/person");
        Snapshot.Match(jsonPerson);
    }
}
