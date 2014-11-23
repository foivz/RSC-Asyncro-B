using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Notification;
using System.Windows;

namespace PhoneApp1
{
    class pushNotification
    {
       /* public pushNotification()
        {
            HttpNotificationChannel pushChannel;
            string channelName = "TileSampleChannel";

           // InitializeComponent();

            pushChannel = HttpNotificationChannel.Find(channelName);

            if (pushChannel == null)
            {
                pushChannel = new HttpNotificationChannel(channelName);

                pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(PushChannel_ChannelUriUpdated);
                pushChannel.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(PushChannel_ErrorOccurred);

                pushChannel.Open();
                pushChannel.BindToShellTile();


            }
            else
            {
                // The channel was already open, so just register for all the events.
                pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(PushChannel_ChannelUriUpdated);
                pushChannel.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(PushChannel_ErrorOccurred);

                // Display the URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
                System.Diagnostics.Debug.WriteLine(pushChannel.ChannelUri.ToString());
                MessageBox.Show(String.Format("Channel Uri is {0}", pushChannel.ChannelUri.ToString()));
            }
        }

        void PushChannel_ChannelUriUpdated(object sender, NotificationChannelUriEventArgs e)
        {
            
            Dispatcher.BeginInvoke(() =>
            {
                // Display the new URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
                System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString());
                MessageBox.Show(String.Format("Channel Uri is {0}",
                    e.ChannelUri.ToString()));

            });*/
        //}
       /* void PushChannel_ErrorOccurred(object sender, NotificationChannelErrorEventArgs e)
        {
            // Error handling logic for your particular application would be here.
            Dispatcher.BeginInvoke(() =>
                MessageBox.Show(String.Format("A push notification {0} error occurred.  {1} ({2}) {3}",
                    e.ErrorType, e.Message, e.ErrorCode, e.ErrorAdditionalData))
                    );
        }*/


    }
}
