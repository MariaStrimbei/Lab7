package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("Strimbei_Maria_Lab7.MainApplication, Strimbei_Maria_Lab7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc645aa51fb2d5a04261.MainApplication.class, crc645aa51fb2d5a04261.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
