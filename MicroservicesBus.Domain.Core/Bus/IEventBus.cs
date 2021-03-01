using MicroservicesBus.Domain.Core.Commands;
using MicroservicesBus.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroservicesBus.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Commands.Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
