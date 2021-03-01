using System;
using System.Collections.Generic;
using System.Text;
using MicroservicesBus.Domain.Core.Commands;

namespace MicroservicesBus.Appointment.Domain.Commands
{
    public abstract class GetUserCommand : Command
    {
         public int Id { get; protected set; }
    }
}
