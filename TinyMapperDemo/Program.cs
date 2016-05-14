using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nelibur.ObjectMapper;
using Nelibur.ObjectMapper.Bindings;

namespace SimpleMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //First of all Bind Person type to PersonDto type and we don't want map Email property. So it has been ignored.
            TinyMapper.Bind<Person, PersonDto>(config => {
                config.Ignore(x => x.Email);
            });

            var person = new Person { 
                Id = Guid.NewGuid(),
                FirstName = "Luke",
                LastName = "Chen",
                Email = "xiaoyong6906@126.com"
            };

            //Now TinyMapper knows how to map Person object to PersonDto object. Finally, call
            PersonDto personDto = TinyMapper.Map<PersonDto>(person);
            Console.WriteLine("personDto:" + personDto.Id + personDto.FirstName + personDto.LastName + personDto.Email);
            Console.ReadLine();
        }
    }
}
