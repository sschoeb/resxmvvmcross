using Android.Content;
using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Localization;
using Cirrious.MvvmCross.ViewModels;

namespace Test.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void FillValueConverters(IMvxValueConverterRegistry registry)
        {
            base.FillValueConverters(registry);
            registry.AddOrOverwrite("Language", new MvxLanguageConverter());
        }
    }
}