using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMapping
{
    [TypeConverter(typeof(SourceClassonverter))]
    public class SourceClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
