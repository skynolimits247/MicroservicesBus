using MicroservicesBus.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.User.Domain.Events
{
    public class GetUserCreatedEvent : Event
    {
        public int Id { get; private set; }

        public GetUserCreatedEvent(int id)
        {
            Id = id;
        }
    }
}
