using Microsoft.Extensions.Logging;
using System.Globalization;
using ClassLibrary1;
using System.Text;

namespace MauiApp12;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        CultureInfo tr = new CultureInfo("tr-TR", false);
        string test = "i";
        var test2 = test.ToUpper(tr);
        var testResult = test2 == "İ";

        return builder.Build();
    }
}
