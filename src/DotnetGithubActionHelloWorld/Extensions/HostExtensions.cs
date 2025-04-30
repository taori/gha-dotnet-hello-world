// This file is licensed to you under the MIT license.

namespace DotnetGithubActionHelloWorld.Extensions;

internal static class HostExtensions
{
	public static TService GetService<TService>(this IHost host)
		where TService : notnull =>
		host.Services.GetRequiredService<TService>();
}