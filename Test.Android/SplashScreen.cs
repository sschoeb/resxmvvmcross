using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Test.Android
{
    [Activity(Label = "Test.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}