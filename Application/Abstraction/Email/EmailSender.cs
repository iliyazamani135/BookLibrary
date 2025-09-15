public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string to, string subject, string body)
    {
       
        Console.WriteLine($"Email sent to {to}: {subject}");
        return Task.CompletedTask;
    }
}
