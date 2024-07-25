// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using Microsoft.JSInterop;

namespace bClipboard
{
    internal partial class ClipboardService
    {
        public async ValueTask CopyTextToClipboard(string text)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("copyTextToClipboard", text);
        }

        public async ValueTask<string> ReadTextFromClipboard()
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("readTextFromClipboard");
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
