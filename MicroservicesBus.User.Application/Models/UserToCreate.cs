using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.User.Application.Models
{
    public class UserToCreate
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> AreaOfCoverage { get; set; }

        public List<string> Specialization { get; set; }

        public string PhoneNumber { get; set; }

        public string Role { get; set; }

        public string Gender { get; set; }
    }
}
