using System.Text.Json.Serialization;

namespace MicroservicesBus.User.Domain.Models
{
    public enum Gender
    {
        male = 1, female, others
    }
    public enum UserType
    {
        admin = 1, user, serviceprovider
    }
    public class UserProfile
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string AreaOfCoverage { get; set; }

        public string Specialization { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserType Role { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }

        public int NumberOfAppointments { get; set; }
    }
}

