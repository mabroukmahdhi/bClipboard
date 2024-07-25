// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Moq;

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
            await clipboardService.CopyTextToClipboard(inputText);

            // Then
            var invocation = this.JSInterop.VerifyInvoke("copyTextToClipboard");
            invocation.Arguments.Count.Should().Be(1);
            invocation.Arguments.Should().Contain(expectedText);
        }
    }
}