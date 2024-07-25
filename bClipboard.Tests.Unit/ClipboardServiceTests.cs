// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using bClipboard.Extensions;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Tynamix.ObjectFiller;

namespace bClipboard.Tests.Unit
{
    public partial class ClipboardServiceTests : TestContext
    {
        public ClipboardServiceTests()
        {
            this.JSInterop.Mode = JSRuntimeMode.Loose;
            this.Services.AddBClipboardService();
        }

        private static string GetRandomString() => new MnemonicString().GetValue();
    }
}