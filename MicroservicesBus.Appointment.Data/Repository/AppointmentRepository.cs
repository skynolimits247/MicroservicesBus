using MicroservicesBus.Appointment.Data.Context;
using MicroservicesBus.Appointment.Domain.Interfaces;
using MicroservicesBus.Appointment.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.Data.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private bool flag;
        private readonly AppointmentDbContext _appointmentDbContext;
        public AppointmentRepository(AppointmentDbContext appointmentDbContext)
        {
            _appointmentDbContext = appointmentDbContext;
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAllAppointments()
        {
            return await _appointmentDbContext.Appointments.ToListAsync();
        }

        public async Task<bool> CreateAppointment(AppointmentEntity appointmentToCreate)
        {
            try
            {
                _appointmentDbContext.Appointments.Add(appointmentToCreate);
                _appointmentDbContext.SaveChanges();
                flag = true;
                return await Task.FromResult(flag);
            }
            catch
            {
                flag = false;
                return await Task.FromResult(flag);
            }
        }

        public async Task<bool> AssignAppointmentToServiceProvider(AssignAppointmentDTO assignAppointmentDTO)
        {
            try
            {
                AppointmentEntity appointment = _appointmentDbContext.Appointments.First(x => x.Id == assignAppointmentDTO.AppointmentId);
                appointment.AssignedTo = assignAppointmentDTO.UserToAssignId;
                _appointmentDbContext.Update(appointment);
                _appointmentDbContext.SaveChanges();
                flag = true;
                return await Task.FromResult(flag);
            }
            catch
            {
                flag = false;
                return await Task.FromResult(flag);
            }
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByServiceProviderId(int id)
        {
            List<AppointmentEntity> appointments = _appointmentDbContext.Appointments.Where(s =>
           (s.AssignedTo == id)).ToList();
            return await Task.FromResult(appointments);
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByUserId(int id)
        {
            List<AppointmentEntity> appointments = _appointmentDbContext.Appointments.Where(s =>
           (s.CreatedBy == id)).ToList();
            return await Task.FromResult(appointments);
        }

        public async Task<AppointmentEntity> GetAppointmentsById(int id)
        {
            AppointmentEntity appointments = _appointmentDbContext.Appointments.First(s =>
           (s.Id == id));
            return await Task.FromResult(appointments);
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentsByStatus(string appointmentStatus)
        {
            if (Enum.IsDefined(typeof(AppointmentStatus), appointmentStatus.ToLower()))
            {
                AppointmentStatus value = (AppointmentStatus)Enum.Parse(typeof(AppointmentStatus), appointmentStatus.ToLower(), true);

                return await _appointmentDbContext.Appointments.Where(s =>
                s.AppointmentStatus == value).ToListAsync();
            } 
            else
            {
                return null;
            }
           
        }
    }
}
