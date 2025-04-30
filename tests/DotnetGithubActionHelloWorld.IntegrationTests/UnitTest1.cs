using DotnetGithubActionHelloWorld.Tests.Shared;

using Shouldly;

using Xunit;

namespace DotnetGithubActionHelloWorld.IntegrationTests;

public class UnitTest1
{
	private readonly ITestOutputHelper _outputHelper;

	[Fact]
    public async Task Test1()
    {
	    var w = Path.GetTempPath();
	    await Task.Run(async () => await Program.Main(["-w", w]));
    }

    public UnitTest1(ITestOutputHelper outputHelper)
    {
	    _outputHelper = outputHelper;
    }
}