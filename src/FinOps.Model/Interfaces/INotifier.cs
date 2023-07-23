namespace FinOps.Model.Interfaces
{
    public interface INotifier
    {
        List<Notification> GetNotifications();
        void Handle(Notification notificacao);
        bool HasNotification();
    }
}