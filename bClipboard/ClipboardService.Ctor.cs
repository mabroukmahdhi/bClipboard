// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using Microsoft.JSInterop;

namespace bClipboard
{
#if NET8_0
    internal partial class ClipboardService(IJSRuntime jsRuntime) : IClipboardService, IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask =
            new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                identifier: "import",
                args: "./_content/bClipboard/bclipboard.js").AsTask());
    }
#else
    internal partial class ClipboardService : IClipboardService, IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ClipboardService(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                identifier: "import",
                args: "./_content/bClipboard/bclipboard.js").AsTask());
        }
    }
#endif
}
