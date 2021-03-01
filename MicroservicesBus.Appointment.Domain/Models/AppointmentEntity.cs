using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MicroservicesBus.Appointment.Domain.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AppointmentStatus
    {
        [Display(Name = "created")]
        created = 1,
        [Display(Name = "underprocess")]
        underprocess,
        [Display(Name = "assigned")]
        assigned,
        [Display(Name = "completed")]
        completed
    }
    public class AppointmentEntity
    {
        public int Id { get; set; }

        public int AssignedTo { get; set; } = 0;

        public int CreatedBy { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AppointmentStatus AppointmentStatus { get; set; } = AppointmentStatus.created;

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Description { get; set; }

        public string Specialization { get; set; }


    }
}
