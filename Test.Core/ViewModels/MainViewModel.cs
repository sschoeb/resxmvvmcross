using System.Globalization;
using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Localization;
using Cirrious.MvvmCross.ViewModels;

namespace Test.Core.ViewModels
{
    public class MainViewModel
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        private ICommand _toggleLanguage;

        public string Hello
        {
            get { return _hello; }
            set
            {
                _hello = value;
                RaisePropertyChanged(() => Hello);
            }
        }

        public IMvxLanguageBinder TextSource
        {
            get { return new MvxLanguageBinder("", GetType().Name); }
        }
    }
}
