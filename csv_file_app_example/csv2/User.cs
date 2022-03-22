using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv2
{
    public class User
    {
        public string loginEmail;
        public int identifier;
        public string oneTimePassword, recoveryCode, firstName, lastName, department, location;
        public User(string data)
        {
            string[] rowData = data.Split(';');
            this.loginEmail = rowData[0];
            this.identifier = Convert.ToInt32(rowData[1]);
            this.oneTimePassword = rowData[2];
            this.recoveryCode = rowData[3];
            this.firstName = rowData[4];
            this.lastName = rowData[5];
            this.department = rowData[6];
            this.location = rowData[7];
        }
        public override string ToString()
        {
            string str = $"{loginEmail} | {identifier} |" +
                $"{oneTimePassword} | {recoveryCode} | {firstName} | {lastName} | {department} | {location}";
            return str;
        }

    }
}
