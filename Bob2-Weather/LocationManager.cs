using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace UWPWeather
{
    public class LocationManager
    {
        public async static Task<Geoposition> GetPosition()
        {

            //We have to reminder the user change location permissions by redirecting to the location settings on their device
            var accessStatus = await Geolocator.RequestAccessAsync();
            var status = await Geolocator.RequestAccessAsync();

            if (status == GeolocationAccessStatus.Denied)
            {
                //Show some messages to let OP open the location accessing permission
                var uri = new Uri("ms-settings:privacy-location");
                // Launch the URI
                var success = await Windows.System.Launcher.LaunchUriAsync(uri);            
            }


            if (accessStatus != GeolocationAccessStatus.Allowed)
            { MessageDialog msg = new MessageDialog("Location service is turned off. You need to turn it ON is you computer. This app need it to be on.");
               await msg.ShowAsync();
                Application.Current.Exit();
            }
          
            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };// täpsus. 0 täh anna mida saad

            var position = await geolocator.GetGeopositionAsync();

            return position;
        }
    }
}
