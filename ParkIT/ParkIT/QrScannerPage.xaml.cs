using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkIT.QR_service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkIT
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QrScannerPage : ContentPage
	{
		 public QrScannerPage ()
		{
			InitializeComponent ();

            openScanner();
        }

        async void openScanner()
        {
            var scanner = DependencyService.Get<IQRScanner>();
            var result = await scanner.ScanAsync();
            if (result != null)
            {
                txtBarcode.Text = result;
            }

        }

}
}