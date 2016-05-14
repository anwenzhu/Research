using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;

namespace ComplexMapping
{
    class Program
    {
        static void Main(string[] args)
        {

            TinyMapper.Bind<PersonComplex, PersonDtoComplex>(config => {
                config.Ignore(x => x.CreateTime);
                config.Ignore(x => x.Nickname);
                config.Bind(x => x.FirstName, y => y.FirstName);//order property name
            });

            var person = new PersonComplex
            {
                Id = Guid.NewGuid(),
                FirstName = "Luke",
                LastName = "Chen",
                Address = new Address
                {
                    Phone = "XXXX",
                    Street = "IT Street",
                    ZipCode = "424600"
                },
                CreateTime = DateTime.Now,
                Nickname = "Yong",
                Emails = new List<string> { 
                    "xiaoyong6906@126.com",
                    "xiaoyong6907@126.com"
                }                      
            };

            var personDto = TinyMapper.Map<PersonDtoComplex>(person);
            Console.WriteLine(personDto.Nickname == null);
            Console.WriteLine(personDto.FirstName);
            Console.ReadLine();
        }                               
    }
}
