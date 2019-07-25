using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ParkIT.UI_Service;
using System.Net.Http;
using Microsoft.WindowsAzure.MobileServices;
using ParkIT.Models;


namespace ParkIT
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            InitUI();

        }

        private async void poststring()
        {
            var httpClient = new HttpClient();

            var content = new MultipartFormDataContent();

            content.Add(content, "hello");

            var uploadServiceBaseAddress = "http://ohadamir1m3c.azurewebsites.net";

            var httpResponseMessage = await httpClient.PostAsync(uploadServiceBaseAddress, content);

            RemotePathLabel.Text = await httpResponseMessage.Content.ReadAsStringAsync();
        }

        private async void BtnScan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QrScannerPage());
        }

        private async void BtnGenerate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QrGeneratorPage());
        }

        private async void BtnViewMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }

        void InitUI()
        {
            MainButton btnScan = new MainButton() { Text = "Scan", FontSize = 40 };
            MainButton btnGenerate = new MainButton() { Text = "Generate QR Code", FontSize = 40 };
            MainButton btnMap = new MainButton() { Text = "Where Is My Car?", FontSize = 30 };

            btnScan.Clicked += new EventHandler(BtnScan_Clicked);
            btnGenerate.Clicked += new EventHandler(BtnGenerate_Clicked);
            btnMap.Clicked += new EventHandler(BtnViewMap_Clicked);

            stackLayout.Children.Add(btnScan);
            stackLayout.Children.Add(btnGenerate);
            stackLayout.Children.Add(btnMap);
        }

        private void Post_Clicked(object sender, EventArgs e)
        {
            post1();
        }

        private void post1()
        {
            traffic_sign s = new traffic_sign() { id = "aaa"};

            App._mobileServiceClient.GetTable<traffic_sign>().InsertAsync(s);
    
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            delete1();
        }

        private void delete1()
        {
            traffic_sign s = new traffic_sign() { id = "aaa" };

            App._mobileServiceClient.GetTable<traffic_sign>().DeleteAsync(s);

        }
    }

}
