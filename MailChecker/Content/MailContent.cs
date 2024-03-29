namespace MailChecker.Content;

public class MailContent
{
    public string? Subject { get; }
    public string? Body { get; }
    public bool IsBodyHtml { get; }

    internal MailContent(string subject, string body, bool isBodyHtml)
    {
        Subject = subject;
        Body = body;
        IsBodyHtml = isBodyHtml;
    }
}