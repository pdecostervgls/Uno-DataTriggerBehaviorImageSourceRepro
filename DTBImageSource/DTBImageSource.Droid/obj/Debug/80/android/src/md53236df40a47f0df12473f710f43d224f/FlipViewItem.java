package md53236df40a47f0df12473f710f43d224f;


public class FlipViewItem
	extends md5f3b65cf7af3f10b96d40f22c7db07a9e.SelectorItem
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Windows.UI.Xaml.Controls.FlipViewItem, Uno.UI", FlipViewItem.class, __md_methods);
	}


	public FlipViewItem (android.content.Context p0)
	{
		super (p0);
		if (getClass () == FlipViewItem.class)
			mono.android.TypeManager.Activate ("Windows.UI.Xaml.Controls.FlipViewItem, Uno.UI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
