<p align="center">
  <img  src="https://github.com/mabroukmahdhi/bClipboard/blob/main/clipboard.png">
</p>


# bClipboard

bClipboard is a Blazor library that simplifies clipboard operations for Blazor applications. It provides methods to copy text to and read text from the clipboard using JavaScript interop.

[![Nuget](https://img.shields.io/nuget/v/bClipboard)](https://www.nuget.org/packages/bClipboard/)
[![Nuget](https://img.shields.io/nuget/dt/bClipboard)](https://www.nuget.org/packages/bClipboard/)
![GitHub](https://img.shields.io/github/license/mabroukmahdhi/bClipboard)

## Features

- **Copy to Clipboard**: Easily copy text to the clipboard.
- **Read from Clipboard**: Read text from the clipboard.
- **Blazor Integration**: Seamlessly integrate with Blazor applications.
- **JavaScript Interop**: Utilizes JavaScript interop for clipboard operations.

## Installation

To install bClipboard, you need to add the NuGet package to your Blazor project:

```shell
dotnet add package bClipboard
```

## Usage
### Register the Clipboard Service
In your `Program.cs` file, register the `ClipboardService` with the dependency injection container.

```csharp
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using bClipboard;
using System.Threading.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddBClipboardService();

await builder.Build().RunAsync();
```

### Use the Clipboard Service in Your Blazor Component

Inject the `IClipboardService` into your Blazor component and use its methods to copy to and read from the clipboard.

```csharp
@page "/clipboard"
@inject IClipboardService ClipboardService

<h3>Clipboard Example</h3>

<input @bind="textToCopy" placeholder="Enter text to copy" />
<button @onclick="CopyToClipboard">Copy Text</button>

<p>Clipboard Content: @clipboardContent</p>
<button @onclick="ReadFromClipboard">Read Clipboard</button>

@code {
    private string textToCopy;
    private string clipboardContent;

    private async Task CopyToClipboard()
    {
        await ClipboardService.CopyToClipboardAsync(textToCopy);
    }

    private async Task ReadFromClipboard()
    {
        clipboardContent = await ClipboardService.ReadFromClipboardAsync();
    }
}

```

### JavaScript Interop
The library uses a JavaScript file ([`bclipboard.js`](https://github.com/mabroukmahdhi/bClipboard/blob/main/bClipboard/wwwroot/bclipboard.js)) for clipboard operations.

## Contributing
We welcome contributions! Please see our [contributing guidelines](https://github.com/mabroukmahdhi/bClipboard/blob/main/Constributing.md) for more details.