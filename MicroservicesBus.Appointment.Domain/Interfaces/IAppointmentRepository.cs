using MicroservicesBus.Appointment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<bool> AssignAppointmentToServiceProvider(AssignAppointmentDTO assignAppointmentDTO);
        Task<bool> CreateAppointment(AppointmentEntity appointmentToCreate);
        Task<IEnumerable<AppointmentEntity>> GetAllAppointments();
        Task<AppointmentEntity> GetAppointmentsById(int id);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByServiceProviderId(int id);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByStatus(string appointmentStatus);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByUserId(int id);
    }
}
