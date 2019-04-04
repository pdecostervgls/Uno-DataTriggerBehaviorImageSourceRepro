package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("DTBImageSource.Droid.Application, DTBImageSource.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md59cc35dfeeb61cc7256ba428cf1d6fbf9.Application.class, md59cc35dfeeb61cc7256ba428cf1d6fbf9.Application.__md_methods);
		mono.android.Runtime.register ("Windows.UI.Xaml.NativeApplication, Uno.UI, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null", md5bf4da100b2dbb022d895d9bb2c38dfa6.NativeApplication.class, md5bf4da100b2dbb022d895d9bb2c38dfa6.NativeApplication.__md_methods);
		
	}
}
