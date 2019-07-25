using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkIT.Views;
using Microsoft.WindowsAzure.MobileServices;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ParkIT
{
    public partial class App : Application
    {
        public static MobileServiceClient _mobileServiceClient = new MobileServiceClient("https://parkitmobileapp.azurewebsites.net");


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); //new NavigationPage(new MainPage()) {
             //   BarBackgroundColor = Color.DarkGray,
               // BarTextColor = Color.White
           // };
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
