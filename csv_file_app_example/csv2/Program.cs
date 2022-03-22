using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace csv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rawCSV = File.ReadAllText("D:\\csv_files\\email-password-recovery.csv");
            //Console.WriteLine(rawCSV);
            //byte[] btsCSV = File.ReadAllBytes("D:\\csv_files\\email-password-recovery.csv");
            //foreach (var item in btsCSV)
            //{
            //    Console.Write($"{item} |");
            //}
            //byte[] bt = new byte[3] { 74, 71,123 };
            //foreach (var b in bt)
            //{
            //    Console.WriteLine($"byte {b}");
            //}
            //string res = Encoding.ASCII.GetString(bt);
            //Console.WriteLine(res);
            string[] rawsCSVs = File.ReadAllLines("C:\\Users\\vikto\\OneDrive\\Documents\\csvexamples\\email-password-recovery.csv");
            //Console.WriteLine(rawsCSVs[0]);

            // List<string> loginEmails = new List<string>();
            // List<string> oneTimePasswords = new List<string>();
            // List<string> recoveryCode = new List<string>();
            // List<string> firstName = new List<string>();
            // List<string> lastName = new List<string>();
            // List<string> department = new List<string>();
            // List<string> location = new List<string>();
            // for (int i = 0; i < rawsCSVs.Length; i++)
            // {
            //     string[] rowData = rawsCSVs[i].Split(';');
            //     loginEmails.Add(rowData[0]);
            //     oneTimePasswords.Add(rowData[1]);
            //     recoveryCode.Add(rowData[2]);
            //     firstName.Add(rowData[3]);
            //     lastName.Add(rowData[4]);
            //     department.Add(rowData[5]);
            //     location.Add(rowData[6]);
            //     //for (int j = 0; j < rowData.Length; j++)
            //     //{
            //     //    Console.WriteLine(rowData[j]);
            //     //}
            // }
            //// Console.WriteLine("login emails");
            // foreach (var email in loginEmails)
            // {
            //     Console.WriteLine(email);
            // }
            // Console.WriteLine(" --------- ");
            // foreach (var pass in oneTimePasswords)
            // {
            //     Console.WriteLine(pass);
            // }
            // Console.WriteLine(" --------- ");
            // foreach (var code in recoveryCode)
            // {
            //     Console.WriteLine(code);
            // }
            // foreach (var first in firstName)
            // {
            //     Console.WriteLine(first);
            // }
            // foreach (var last in lastName)
            // {
            //     Console.WriteLine(last);
            // }
            // foreach (var dp in department)
            // {
            //     Console.WriteLine(dp);
            // }
            // foreach (var l in location)
            // {
            //     Console.WriteLine(l);
            // }

            var user = new List<User>();
            for (int i = 1; i < rawsCSVs.Length; i++)
            {
                User u = new User(rawsCSVs[i]);
                //Console.WriteLine(typeof(rawsCSVs[i]);
                user.Add(u);
            }
            foreach (var item in user)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
