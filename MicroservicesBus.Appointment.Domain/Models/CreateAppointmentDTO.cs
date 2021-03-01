using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.Appointment.Domain.Models
{
    public class CreateAppointmentDTO
    {
        public int CreatedBy { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Description { get; set; }

        public string Specialization { get; set; }

    }
}
