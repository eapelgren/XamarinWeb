using Xamarin.Forms;

namespace XamarinWeb
{
	public partial class XamarinWebPage : ContentPage
	{
		public XamarinWebPage()
		{
			InitializeComponent();
			Browser.Source = "https://www.xamarin.com";
		}
	}
}

