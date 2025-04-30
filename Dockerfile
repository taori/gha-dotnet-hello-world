FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/DotnetGithubActionHelloWorld/DotnetGithubActionHelloWorld.csproj", "DotnetGithubActionHelloWorld/"]
RUN dotnet restore DotnetGithubActionHelloWorld/DotnetGithubActionHelloWorld.csproj
COPY ["src/DotnetGithubActionHelloWorld", "DotnetGithubActionHelloWorld/"]
RUN dotnet publish DotnetGithubActionHelloWorld/DotnetGithubActionHelloWorld.csproj --configuration Release --no-restore --output /publish

# Label the container
LABEL maintainer="taori@users.noreply.github.com"
LABEL repository="https://github.com/taori/gha-dotnet-hello-world"
LABEL homepage="https://github.com/taori/gha-dotnet-hello-world"

# Label as GitHub Action
LABEL com.github.actions.name="gha-dotnet-hello-world-taori"
LABEL com.github.actions.description="this is just a test container with no purpose"
LABEL com.github.actions.icon="book-open"
LABEL com.github.actions.color="purple"

LABEL org.opencontainers.image.source=https://github.com/taori/gha-dotnet-hello-world
LABEL org.opencontainers.image.description="this is just a test container with no purpose"
LABEL org.opencontainers.image.licenses=MIT

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS final
WORKDIR /app
COPY --from=build /publish .
ENV DOTNET_EnableDiagnostics=0
ENTRYPOINT ["dotnet", "/app/DotnetGithubActionHelloWorld.dll"]