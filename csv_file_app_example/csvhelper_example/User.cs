using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace csvhelper_example
{
    public class User
    {
        //[Name("email")]
        public string Email { get; set; }
        //[Name("identifier")]
        public int Identifier { get; set; }
        
        //[Name("password")]
        public string Password { get; set; }
        //[Name("Recoverycode")]
        public string Recoverycode { get; set; }
        //[Name("Firstname")]
        public string Firstname { get; set; }
        //[Name("Lastname")]
        public string Lastname { get; set; }
        //[Name("Department")]
        public string Department { get; set; }
        //[Name("Location")]
        public string Location { get; set; }

    }
}
