using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercio.Domain.Base
{
    public class Result<T>
    {
        public T Value { get; set; }
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public bool HasNotifications => Notifications.Any();

        internal void AddNotification(string code, string description)
        {
            Notifications.Add(new Notification(code, description));
        }
    }

    public class Notification
    {
        public Notification(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public string Code { get; set; }
        public string Description { get; set; }
    }
}
