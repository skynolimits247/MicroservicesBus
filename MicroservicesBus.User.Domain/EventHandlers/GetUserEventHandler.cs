using MicroservicesBus.Domain.Core.Bus;
using MicroservicesBus.User.Domain.Events;
using MicroservicesBus.User.Domain.Interfaces;
using System.Threading.Tasks;

namespace MicroservicesBus.User.Domain.EventHandlers
{
    public class GetUserEventHandler : IEventHandler<GetUserCreatedEvent>
    {
        private IUserProfileRepository _userProfileRepository;
        public GetUserEventHandler()
        {

        }
        public GetUserEventHandler(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public Task Handle(GetUserCreatedEvent @event)
        {
            _userProfileRepository.UpdateNumberOfAppointemnts(@event.Id);
            return Task.CompletedTask;
        }
    }
}
