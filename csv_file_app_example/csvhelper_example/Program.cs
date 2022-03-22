using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Globalization;
using System.Linq;

namespace csvhelper_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
                
            };
            using(var streamReader = new StreamReader("D:\\csv_files\\email-password-recovery.csv"))
            {
                using(var csvReader = new CsvReader(streamReader, config))
                {
                    csvReader.Context.RegisterClassMap<UserMap>();
                    var records = csvReader.GetRecords<User>().ToList();
                    
                }
            }
            Console.ReadLine();
        }
    }
}
