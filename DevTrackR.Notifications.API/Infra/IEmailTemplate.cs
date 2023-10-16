namespace DevTrackR.Notifications.API.Infra
{
    public interface IEmailTemplate
    {
        string Subject { get; set; }
        string Content { get; set; }
        string To { get; set; }
    }
}
