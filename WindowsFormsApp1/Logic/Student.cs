using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Logic
{
    internal class Student
    {
        int sNumber;
        string sName, sSurname, sDOB, sGender, sPhone, sAddress, sModule;

        public Student()
        {
            
        }

        public Student(int sNumber, string sName, string sSurname, string sDOB, string sGender, string sPhone, string sAddress, string sModule)
        {
            this.sNumber = sNumber;
            this.sName = sName;
            this.sSurname = sSurname;
            this.sDOB = sDOB;
            this.sGender = sGender;
            this.sPhone = sPhone;
            this.sAddress = sAddress;
            this.sModule = sModule;
        }

        public int SNumber { get => sNumber; set => sNumber = value; }
        public string SName { get => sName; set => sName = value; }
        public string SSurname { get => sSurname; set => sSurname = value; }
        public string SDOB { get => sDOB; set => sDOB = value; }
        public string SGender { get => sGender; set => sGender = value; }
        public string SPhone { get => sPhone; set => sPhone = value; }
        public string SAddress { get => sAddress; set => sAddress = value; }
        public string SModule { get => sModule; set => sModule = value; }
    }
}
