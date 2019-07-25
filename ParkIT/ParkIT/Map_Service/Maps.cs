using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;


namespace ParkIT.Map_Service
{
    public class Maps
    {
        public async Task ShowOnMap()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.None };

            await Map.OpenAsync(location, options);
        }

        public async Task NavigateWalking()
            {
                var location = new Location(47.645160, -122.1306032);
                var options = new MapLaunchOptions { NavigationMode = NavigationMode.Walking };

                await Map.OpenAsync(location, options);
            }

        public async Task NavigateDriving()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Map.OpenAsync(location, options);
        }
    }
}
