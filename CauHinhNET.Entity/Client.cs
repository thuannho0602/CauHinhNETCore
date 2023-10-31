using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauHinhNET.Entity
{
    [Table("Client")]
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddRess { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
