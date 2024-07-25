// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace bClipboard.Tests.Unit
{
    public partial class ClipboardServiceTests
    {
        [Fact]
        public async Task ShouldCopyTextToClipboard()
        {
            // given
            var clipboardService = Services.GetRequiredService<IClipboardService>();
            var randomText = GetRandomString();
            var inputText = randomText;
            var expectedText = randomText;

            // when
            await clipboardService.CopyToClipboardAsync(inputText);

            // Then
            var invocation = this.JSInterop.VerifyInvoke("copyTextToClipboard");
            invocation.Arguments.Count.Should().Be(1);
            invocation.Arguments.Should().Contain(expectedText);
        }

        [Fact]
        public async Task ShouldReadTextFromClipboard()
        {
            // given
            var clipboardService = Services.GetRequiredService<IClipboardService>();
            var randomText = GetRandomString();
            var outputText = randomText;
            var expectedText = randomText;

            this.JSInterop.Setup<string>("readTextFromClipboard")
                .SetResult(outputText);

            // when
            var actualText = await clipboardService.ReadFromClipboardAsync();

            // Then
            actualText.Should().Be(expectedText);
        }
    }
}