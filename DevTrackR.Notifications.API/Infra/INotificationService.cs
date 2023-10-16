namespace DevTrackR.Notifications.API.Infra
{
    public interface INotificationService
    {
        Task Send(IEmailTemplate template);
    }
}
