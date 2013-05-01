using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Test.Core.ViewModels;

namespace Test.iOS.Views
{
    [Register("MainView")]
    public class MainView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
			label.Text = Localization.Strings.MainViewModel_test1;

			var label2= new UILabel(new RectangleF(10, 50, 300, 40));
			Add(label2);
			label2.Text = ((MainViewModel)ViewModel).TextSource.GetText("test2");

        }
    }
}