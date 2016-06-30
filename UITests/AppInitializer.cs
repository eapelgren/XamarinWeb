using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinWeb.UITests
{
	public class AppInitializer
	{
		const string simId = "5BF912AF-EB50-4C3D-8CAB-6F732C50DF85"; //iPhone 5s (8.1 Simulator)

		public static IApp StartApp(Platform platform)
		{
	
			{
				return ConfigureApp.Android.StartApp();
			}

		
			//return ConfigureApp.iOS.DeviceIdentifier(simId).StartApp();

		}
	}
}

