package cirrious.mvvmcross.binding.droid.views;


public class MvxTimeChangedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.TimePicker.OnTimeChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTimeChanged:(Landroid/widget/TimePicker;II)V:GetOnTimeChanged_Landroid_widget_TimePicker_IIHandler:Android.Widget.TimePicker/IOnTimeChangedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Cirrious.MvvmCross.Binding.Droid.Views.MvxTimeChangedListener, Cirrious.MvvmCross.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxTimeChangedListener.class, __md_methods);
	}


	public MvxTimeChangedListener ()
	{
		super ();
		if (getClass () == MvxTimeChangedListener.class)
			mono.android.TypeManager.Activate ("Cirrious.MvvmCross.Binding.Droid.Views.MvxTimeChangedListener, Cirrious.MvvmCross.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTimeChanged (android.widget.TimePicker p0, int p1, int p2)
	{
		n_onTimeChanged (p0, p1, p2);
	}

	private native void n_onTimeChanged (android.widget.TimePicker p0, int p1, int p2);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
