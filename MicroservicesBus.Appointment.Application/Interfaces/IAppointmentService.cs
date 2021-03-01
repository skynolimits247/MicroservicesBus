using MicroservicesBus.Appointment.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.Application.Services
{
    public interface IAppointmentService
    {
        Task<bool> AssignAppointmentToServiceProvider(AssignAppointmentDTO assignAppointmentDTO);
        Task<bool> CreateAppointment(AppointmentEntity appointmentToCreate);
        Task<IEnumerable<AppointmentEntity>> GetAllAppointments();
        Task<AppointmentEntity> GetAppointmentsById(int id);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByServiceProviderId(int id);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByStatus(string appointmentStatus);
        Task<IEnumerable<AppointmentEntity>> GetAppointmentsByUserId(int id);
        void GetUser(int id);

    }
}