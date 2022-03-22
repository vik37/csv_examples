using System;
using System.Collections.Generic;
using System.IO;

namespace csv_file_app_example
{
    class Program
    {
        static void Main(string[] args)
        {
            AddRecords("124", "Mercy", "56", "cake.txt");
            Console.ReadLine();
        }
        public static void AddRecords(string ID, string name, string age, string filepath)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine(ID + "," + name + "," + age);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("This program did an oopsie: ", ex);
            }
        }
    }
}
