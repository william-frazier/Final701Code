using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
			var tabs = new TabbedPage ();
            
			tabs.Children.Add (new LocalHtmlBaseUrl {Title = "BaseUrl" });

			MainPage = tabs;
		}
	}
}

