using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvhelper_example
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Identifier).Name("identifier");
            Map(m => m.Email).Name("email");
            Map(m => m.Password).Name("password");
            Map(m => m.Recoverycode).Name("Recoverycode");
            Map(m => m.Firstname).Name("Firstname");
            Map(m => m.Lastname).Name("Lastname");
            Map(m => m.Department).Name("Department");
            Map(m => m.Location).Name("Location");
        }
    }
}
