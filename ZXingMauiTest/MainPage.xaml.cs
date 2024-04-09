using ZXing.Net.Maui;

namespace ZXingMauiTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.OneDimensional,
            AutoRotate = true,
            Multiple = true
        };
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var res = e.Results?.FirstOrDefault();
        if (res != null)
        {
            Console.WriteLine($"Barcodes: {res.Format} -> {res.Value}");
            DisplayAlert("Resultado", $"Contenido del {res.Format} -> {res.Value}", "OK");
        }
    }
}
