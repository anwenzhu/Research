using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyMapper.Bind<SourceClass, TargetClass>();
            var source = new SourceClass { 
                FirstName = "Luke",
                LastName = "Chen"
            };

            var result = TinyMapper.Map<TargetClass>(source);
            Console.WriteLine(result.FullName);
            Console.ReadLine();
        }
    }
}
