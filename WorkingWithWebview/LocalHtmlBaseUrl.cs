using Xamarin.Forms;

namespace WorkingWithWebview
{
    public interface IBaseUrl { string Get(); }

    public class LocalHtmlBaseUrl : ContentPage
    {
        public LocalHtmlBaseUrl()
        {
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
<head>
<link rel=""stylesheet"" href=""default.css"">
</head>
<body>
<h1>Midd Guide</h1>
<p>The app will deploy after you click the link.</p>

<p><a href=""local.html"">Open app.</a></p>
</body>
</html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;
            Content = browser;
        }
    }
}
