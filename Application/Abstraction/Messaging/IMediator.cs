using Application.Abstraction.Messaging;

public interface IMediator
{
    Task Send(global::Web.Controllers.AddBookCommand command);
    Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
    Task<TResult> SendAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
}
