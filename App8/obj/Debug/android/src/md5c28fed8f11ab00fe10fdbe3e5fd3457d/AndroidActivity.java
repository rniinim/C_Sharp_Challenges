package md5c28fed8f11ab00fe10fdbe3e5fd3457d;


public class AndroidActivity
	extends md5c28fed8f11ab00fe10fdbe3e5fd3457d.FormsApplicationActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.AndroidActivity, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", AndroidActivity.class, __md_methods);
	}


	public AndroidActivity ()
	{
		super ();
		if (getClass () == AndroidActivity.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.AndroidActivity, Xamarin.Forms.Platform.Android, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
