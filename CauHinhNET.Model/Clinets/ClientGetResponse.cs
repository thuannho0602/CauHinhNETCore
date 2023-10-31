using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauHinhNET.Model.Clinets
{
    public class ClientGetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddRess { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
