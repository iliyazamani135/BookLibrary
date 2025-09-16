using System.Threading.Tasks;
using Application.Abstraction.Messaging;

namespace Application.Abstractions.Messaging
{
    public interface IMediator
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
        Task<TResult> SendAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}
