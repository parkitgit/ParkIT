using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkIT
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QrGeneratorPage : ContentPage
	{
		public QrGeneratorPage()
		{
			InitializeComponent ();  
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            generateOrCode();
        }

        void generateOrCode()
        {
            QRGenerator QR_Generator = new QRGenerator();
            QR_Generator.setValue(textToQr.Text);
            QRimage.Children.Add(QR_Generator.getQRcode());
        }
    }
}