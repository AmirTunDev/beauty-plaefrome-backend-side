using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using beauty.Models;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly beautyContext _beautyContext;
        public NotificationRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }
        public IEnumerable<Notification> GetAllNotifications()
        {
            return _beautyContext.Notification.ToList();
        }

        public Notification GetNotificationById(int id)
        {
            return _beautyContext.Notification.Find(id);
        }

        public void Insert(Notification notification)
        {
            _beautyContext.Notification.Add(notification);
        }

        public void Update(Notification notification)
        {
            _beautyContext.Entry(notification).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Notification notification = _beautyContext.Notification.Find(id);

            notification.Active = true;
        }
    }
}
