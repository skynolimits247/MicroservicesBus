using MicroservicesBus.Appointment.Application.Services;
using MicroservicesBus.Appointment.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesBus.Appointment.API.Controllers
{
    [ApiController]
    [Route("api2/[controller]")]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        [HttpGet]
        public async Task<ActionResult<List<AppointmentEntity>>> GetAppointments()
        {
            var appointments = await _appointmentService.GetAllAppointments();
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(appointments);
        }

        [Route("assignto")]
        [HttpPost]
        public async Task<ActionResult<bool>> AssignAppointmentToServiceProvider(AssignAppointmentDTO appointmentToAssign)
        {
           var flag =  await _appointmentService.AssignAppointmentToServiceProvider(appointmentToAssign);
            _appointmentService.GetUser(appointmentToAssign.UserToAssignId);
            return Ok(flag);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentEntity>> GetAppointmentsById(int id)
        {
            var appointments = await _appointmentService.GetAppointmentsById(id);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(appointments);
        }
        [Route("assignedto/{id}")]
        [HttpGet]
        public async Task<ActionResult<List<AppointmentEntity>>> GetAppointmentsByServiceproviderId(int id)
        {
            var appointments = await _appointmentService.GetAppointmentsByServiceProviderId(id);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(appointments);
        }

        [Route("createdby/{id}")]
        [HttpGet]
        public async Task<ActionResult<List<AppointmentEntity>>> GetAppointmentsCreatedBy(int id)
        {
            var appointments = await _appointmentService.GetAppointmentsByUserId(id);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(appointments);
        }

        [Route("status/{status}")]
        [HttpGet]
        public async Task<ActionResult<List<AppointmentEntity>>> GetAppointmentsByStatus(string status)
        {
            var appointments = await _appointmentService.GetAppointmentsByStatus(status);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(appointments);
        }

        [Route("assign")]
        [HttpPost]
        public async Task<ActionResult<bool>> AssignAppointment(AssignAppointmentDTO appointmentToAssign)
        {
            var flag = await _appointmentService.AssignAppointmentToServiceProvider(appointmentToAssign);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(flag);
        }

        [Route("create")]
        [HttpPost]
        public async Task<ActionResult<bool>> CreateAppointment(AppointmentEntity appointmentToCreate)
        {
            var flag = await _appointmentService.CreateAppointment(appointmentToCreate);
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(flag);
        }
    }
}
