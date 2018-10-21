using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Common.Domain.Notification
{
    public static class EventPublisher
    {
        public static event EventHandler<NotificationEventArgs> RaiseNotificationEvent;

        public static void OnRaiseNotificationEvent(NotificationEventArgs e)
        {
            var handler = RaiseNotificationEvent;
            if (handler == null) return;
            handler(new object(), e);
        }
    }
}
