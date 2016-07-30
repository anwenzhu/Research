using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexMapping
{
    public class PersonDtoComplex
    {
        public Address Address { get; set; }
        public DateTime CreateTime { get; set; }
        public List<string> Emails { get; set; }
        public string FirstName { get; set; }
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
    }
}
