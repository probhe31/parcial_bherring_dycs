using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Common.Domain.Notification
{
    public class NotificationEventArgs
    {
        public NotificationEventArgs(string s)
        {
            Message = s;
        }


        public string Message { get; set; }
    }
}
