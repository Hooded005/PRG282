using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Logic
{
    internal class Module
    {
        string mCode, mName, mDescription, mResource;

        public Module()
        {
            
        }

        public Module(string mCode, string mName, string mDescription, string mResource)
        {
            this.mCode = mCode;
            this.mName = mName;
            this.mDescription = mDescription;
            this.mResource = mResource;
        }

        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public string MDescription { get => mDescription; set => mDescription = value; }
        public string MResource { get => mResource; set => mResource = value; }
    }
}
