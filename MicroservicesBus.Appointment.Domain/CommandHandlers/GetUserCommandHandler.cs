using MediatR;
using MicroservicesBus.Appointment.Domain.Commands;
using MicroservicesBus.Appointment.Domain.Events;
using MicroservicesBus.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.Domain.CommandHandlers
{
    public class GetUserCommandHandler : IRequestHandler<CreateGetUserCommand, bool>
    {
        private readonly IEventBus _bus;
        public GetUserCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateGetUserCommand request, CancellationToken cancellationToken)
        {
            // publish event to bus
            _bus.Publish(new GetUserCreatedEvent(request.Id));

            return Task.FromResult(true);
        }
    }
}
