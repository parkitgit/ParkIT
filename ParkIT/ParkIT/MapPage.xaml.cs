using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkIT.UI_Service;
using ParkIT.Map_Service;

namespace ParkIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            initPage();
        }

        void initPage()
        {
            MainButton btnViewMap = new MainButton() { Text = "View On Map", FontSize = 40 };
            btnViewMap.Clicked += new EventHandler(BtnViewMap_Clicked);
            stackLayout.Children.Add(btnViewMap);

            MainButton btnNavigateWalking = new MainButton() { Text = "Navigate Walking", FontSize = 40 };
            btnNavigateWalking.Clicked += new EventHandler(BtnNavigateWalking_Clicked);
            stackLayout.Children.Add(btnNavigateWalking);

            MainButton btnNavigateDriving = new MainButton() { Text = "Navigate Driving", FontSize = 40 };
            btnNavigateDriving.Clicked += new EventHandler(BtnNavigateDriving_Clicked);
            stackLayout.Children.Add(btnNavigateDriving);
        }

        private async void BtnViewMap_Clicked(object sender, EventArgs e)
        {
            Maps map = new Maps();
            await map.ShowOnMap();
        }

        private async void BtnNavigateWalking_Clicked(object sender, EventArgs e)
        {
            Maps map = new Maps();
            await map.NavigateWalking();
        }

        private async void BtnNavigateDriving_Clicked(object sender, EventArgs e)
        {
            Maps map = new Maps();
            await map.NavigateDriving();
        }
    }
}