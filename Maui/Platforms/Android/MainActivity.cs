using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views; // necessário para StatusBarVisibility
using Android.Graphics;
using Color = Android.Graphics.Color; // necessário para Android.Graphics.Color

namespace Maui
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                               ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            Window.SetStatusBarColor(Color.ParseColor("#F8FAFF"));
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;

   
            Window.SetNavigationBarColor(Color.ParseColor("#F8FAFF"));
            Window.DecorView.SystemUiVisibility |= (StatusBarVisibility)SystemUiFlags.LightNavigationBar;
        }
    }
}