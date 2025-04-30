using DotnetGithubActionHelloWorld.Tests.Shared;

using Microsoft.Extensions.Logging.Abstractions;

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
	    await CoreProcedure.ExecuteAsync(NullLogger<CoreProcedure>.Instance, new ActionInputs()
	    {
		    WorkspaceDirectory = w,
	    }, TestContext.Current.CancellationToken);
	    
    }

    public UnitTest1(ITestOutputHelper outputHelper)
    {
	    _outputHelper = outputHelper;
    }
}