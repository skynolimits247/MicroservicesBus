using System;
using System.Collections.Generic;
using System.Text;
using MicroservicesBus.Domain.Core.Events;

namespace MicroservicesBus.Appointment.Domain.Events
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
