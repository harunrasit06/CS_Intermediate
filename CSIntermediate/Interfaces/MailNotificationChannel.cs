﻿using System;

namespace CSIntermediate.Interfaces
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
