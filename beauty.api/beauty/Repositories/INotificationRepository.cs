using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Models;

namespace beauty.Repositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetAllNotifications();
        Notification GetNotificationById(int id);
        void Insert(Notification notification);
        void Update(Notification notification);
        void Delete(int id);
    }
}
