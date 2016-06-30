using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinWeb.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			var res = app.Query(c => c.WebView());
			var xpath = "//*[@id=\"test\"]/div/div/div[1]/div/a[1]";
			app.ScrollDownTo(c => c.XPath(xpath), swipeSpeed:3000);
			//app.Tap(b => b.XPath(xpath));
			app.Repl();
			var res2 = app.Query(c => c.XPath("//*[@id=\"container\"]/div[2]/div/a"));
			app.Screenshot("Welcome screen.");


			Assert.IsTrue(res2.Any());
		}
	}
}

