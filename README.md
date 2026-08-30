[![](https://img.shields.io/nuget/v/Soenneker.Utils.Cancellation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Cancellation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.cancellation/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.cancellation/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Utils.Cancellation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Cancellation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.cancellation/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.cancellation/actions/workflows/codeql.yml)

# Soenneker.Utils.Cancellation

A small scoped holder for passing one `CancellationToken` between services resolved from the same dependency-injection scope.

## Installation

```bash
dotnet add package Soenneker.Utils.Cancellation
```

## Registration

```csharp
builder.Services.AddCancellationUtil();
```

`ICancellationUtil` is registered as scoped. Do not inject it into a singleton.

## Usage

Set the request or operation token near the scope boundary:

```csharp
public async Task<IResult> Import(
    ICancellationUtil cancellation,
    IImporter importer,
    CancellationToken cancellationToken)
{
    cancellation.Set(cancellationToken);
    await importer.Run();
    return Results.Ok();
}
```

Another service in that same scope can retrieve it:

```csharp
CancellationToken cancellationToken = cancellation.Get();
await client.SendAsync(request, cancellationToken);
```

`Get()` returns `CancellationToken.None` when no value has been set. Calling `Set()` again replaces the stored token.

This type is a mutable scoped value, not an `AsyncLocal` context. Do not use one scope for concurrent operations that need different tokens; pass tokens explicitly in that situation.
