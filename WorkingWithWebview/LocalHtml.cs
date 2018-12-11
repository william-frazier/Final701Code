using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class LocalHtml : ContentPage
    {
        public LocalHtml()
        {
            var browser = new WebView();

            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
</html>";

            browser.Source = htmlSource;
            Content = browser;
        }
    }
}
