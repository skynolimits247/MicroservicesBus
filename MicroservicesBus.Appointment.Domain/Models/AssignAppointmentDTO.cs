using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.Appointment.Domain.Models
{
    public class AssignAppointmentDTO
    {
        public int AppointmentId { get; set; }

        public int UserToAssignId { get; set; }
    }
}
