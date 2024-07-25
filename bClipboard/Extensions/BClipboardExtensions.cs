// ---------------------------------------------------------------
// Copyright (c) All Sweet Hearted Engineers.
// ---------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace bClipboard.Extensions
{
    public static class BClipboardExtensions
    {
        public static void AddBClipboardService(this IServiceCollection services)
        {
            services.AddScoped<IClipboardService, ClipboardService>();
        }
    }
}
