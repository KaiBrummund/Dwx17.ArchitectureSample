using Android.App;
using Android.Widget;
using Android.OS;

namespace Dwx17.Clients.AndroidApp
{
    [Activity(Label = "Dwx17.Clients.AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

