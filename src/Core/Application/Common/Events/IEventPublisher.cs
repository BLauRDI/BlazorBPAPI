using BlazorBP.Shared.Events;

namespace BlazorBP.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}