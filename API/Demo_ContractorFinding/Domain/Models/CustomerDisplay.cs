using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CustomerDisplay:TbCustomer
    {
       
        public string? BuildingType { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public string EmailId { get; set; } = null!;

    }
}
