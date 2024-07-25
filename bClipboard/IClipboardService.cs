// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

namespace bClipboard
{
    public interface IClipboardService
    {
        ValueTask CopyTextToClipboard(string text);
        ValueTask<string> ReadTextFromClipboard();
    }
}
