
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Test.Core.ViewModels;
using Cirrious.MvvmCross.Localization;

namespace Test.iOS
{
	public partial class MainView : MvxViewController
	{
		public MainView () : base ("MainView", null)
		{
		}
		

		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			

			var bindingSet = this.CreateBindingSet<MainView, MainViewModel>();
			bindingSet.Bind(Label1).To(ViewModel => ViewModel.TextSource)
								   .WithConversion(new MvxLanguageConverter(),"test1")
					.Apply();

			bindingSet.Bind(Label2).To(ViewModel => ViewModel.TextSource)
				.WithConversion(new MvxLanguageConverter(),"test2")
					.Apply();
		}
	}
}

