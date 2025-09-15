using Application.Abstractions.Email;

namespace Infrastructure.Email;

public class EmailService : IEmailService
{
    public async Task SendAsync(string to, string subject, string body)
    {
        
        Console.WriteLine($"[EMAIL] To: {to}, Subject: {subject}");
        await Task.CompletedTask;
    }
}
