using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivApp
{
    internal class InsertData
    {
        public InsertData(string fileName , string firstName , String lastName , int age , string email)
        {
            StreamWriter stream = new StreamWriter(fileName, true);
            stream.WriteLine( " name : " + firstName + "  "+ lastName);
            stream.WriteLine(" age : " + age );
            stream.WriteLine(" email : " + email);
            stream.Close();
        }
        public InsertData(string fileName, string firstName, String lastName, string email, string department)
        {
            StreamWriter stream = new StreamWriter(fileName, true);
            stream.WriteLine(" name : " + firstName + "  " + lastName);
            stream.WriteLine(" email : " + email);
            stream.WriteLine(" department : " + department);
            stream.Close();
        }
        public InsertData(string fileName , string name)
        {
            StreamWriter str = new StreamWriter(fileName, true);
            str.WriteLine(" name : "+ name);
            str.Close();
        }
    }
}
