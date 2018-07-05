using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UiTestNunit3
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
                return ConfigureApp
                    .Android
                    .ApkFile(@"C:\Users\John Kenneth Furog\source\repos\POC_Specflow\POC_Specflow\POC_Specflow.Android\bin\Debug\com.companyname.appname.apk")
                    .StartApp();
            }

			return ConfigureApp.iOS.StartApp();
		}
	}
}