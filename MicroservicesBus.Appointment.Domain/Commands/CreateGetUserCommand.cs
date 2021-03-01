using MicroservicesBus.Appointment.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.Appointment.Domain.Commands
{
    public class CreateGetUserCommand : GetUserCommand
    {
        public CreateGetUserCommand(int id)
        {
            Id = id;
        }
    }
}
