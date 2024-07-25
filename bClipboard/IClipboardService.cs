// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

namespace bClipboard
{
    public interface IClipboardService
    {
        ValueTask CopyToClipboardAsync(string text);
        ValueTask<string> ReadFromClipboardAsync();
    }
}
