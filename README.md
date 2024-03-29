[![](https://img.shields.io/nuget/v/Soenneker.Utils.Cancellation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Cancellation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.cancellation/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.cancellation/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Utils.Cancellation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Utils.Cancellation/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.Cancellation
### A utility library allowing for easy CancellationToken usage

## Installation

```
dotnet add package Soenneker.Utils.Cancellation
```

## Usage

1. Register the interop within DI (`Program.cs`).

```csharp
public static async Task Main(string[] args)
{
    ...
    builder.Services.AddCancellationUtil();
}
```

2. Inject `ICancellationUtil` where you wish to set the `CancellationToken` (typically from an API Controller)

```csharp
_cancellationUtil.Set(cancellationToken);
```

3. Inject `ICancellationUtil` where you wish to retrieve the `CancellationToken` (typically when accessing another API, or database etc):

```csharp
// is not guaranteed to be non-null (if it never was set within scope), but is specified thus for ease of use
var cancellationUtil = _cancellationUtil.Get(); 
```