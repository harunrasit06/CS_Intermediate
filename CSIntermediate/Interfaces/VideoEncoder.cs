using System.Collections;
using System.Collections.Generic;

namespace CSIntermediate.Interfaces
{
    
    public class VideoEncoder
    {
        
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder() 
        {
            _notificationChannels = new List<INotificationChannel>();

        }
        public void Encode(Video video)
        {
            // Video encoding logic
            //...
            foreach (var channel1 in _notificationChannels)
            {
                channel1.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

       
    }
}
