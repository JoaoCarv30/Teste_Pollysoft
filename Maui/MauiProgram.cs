using Microsoft.Extensions.Logging;

#if ANDROID
using Android.Graphics.Drawables;
using Microsoft.Maui.Handlers;
#endif

namespace Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("DMSansRegular.ttf", "DMSansRegular");
                    fonts.AddFont("DMSansBold.ttf", "DMSansBold");
                });

#if ANDROID
            EntryHandler.Mapper.AppendToMapping("RemoveUnderline", (handler, view) =>
            {
          
                handler.PlatformView.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.SetHighlightColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.SetHintTextColor(Android.Graphics.Color.Gray); // cor do placeholder
            });

     
            EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                handler.PlatformView.BackgroundTintList =
                    Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            });
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}