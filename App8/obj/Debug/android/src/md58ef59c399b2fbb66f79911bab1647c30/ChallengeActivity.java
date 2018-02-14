package md58ef59c399b2fbb66f79911bab1647c30;


public class ChallengeActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("C_Sharp_Challenges.ChallengeActivity, C_Sharp_Challenges, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChallengeActivity.class, __md_methods);
	}


	public ChallengeActivity ()
	{
		super ();
		if (getClass () == ChallengeActivity.class)
			mono.android.TypeManager.Activate ("C_Sharp_Challenges.ChallengeActivity, C_Sharp_Challenges, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
