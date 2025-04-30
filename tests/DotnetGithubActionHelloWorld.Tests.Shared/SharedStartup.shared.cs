using System.Runtime.CompilerServices;
 
namespace DotnetGithubActionHelloWorld.Tests.Shared;

public class SharedStartup
{
	[ModuleInitializer]
	public static void Initialize()
	{
		VerifyInitializer.Initialize();
	}
}