using MicroservicesBus.Appointment.Domain.Commands;
using MicroservicesBus.Appointment.Domain.Interfaces;
using MicroservicesBus.Appointment.Domain.Models;
using MicroservicesBus.Domain.Core.Bus;
using MicroservicesBus.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IEventBus _bus;
        public AppointmentService(IAppointmentRepository appointmentRepository, IEventBus bus)
        {
            _appointmentRepository = appointmentRepository;
            _bus = bus;
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAllAppointments()
        {
            return await _appointmentRepository.GetAllAppointments();
        }

        public async Task<bool> CreateAppointment(AppointmentEntity appointmentToCreate)
        {
            return await _appointmentRepository.CreateAppointment(appointmentToCreate);
        }

        public async Task<bool> AssignAppointmentToServiceProvider(AssignAppointmentDTO assignAppointmentDTO)
        {
            return await _appointmentRepository.AssignAppointmentToServiceProvider(assignAppointmentDTO);
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByServiceProviderId(int id)
        {
            return await _appointmentRepository.GetAppointmentsByServiceProviderId(id);
        }
        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByUserId(int id)
        {
            return await _appointmentRepository.GetAppointmentsByUserId(id);
        }

        public async Task<AppointmentEntity> GetAppointmentsById(int id)
        {
            return await _appointmentRepository.GetAppointmentsById(id);
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByStatus(string appointmentStatus)
        {
            return await _appointmentRepository.GetAppointmentsByStatus(appointmentStatus);
        }

        public void GetUser(int id)
        {
            var getUserCommand = new CreateGetUserCommand(
                id
                );
            _bus.SendCommand(getUserCommand);
        }
    }
}
