using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.User.Domain.Models
{
    public class FindUserCategoryDTO
    {
        public string Zip { get; set; }

        public string Category { get; set; }
    }
}
