using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEducation
{
    public class Server
    {
        public string Model { get; set;}
        public bool Virtual;
        public string dataCenter;
        public int Processor;
        public int Memory;
        protected int HDD;

        public Server (string model, string datacenter)
            {
            Model = model;
            dataCenter = datacenter;
            }

        public int Power
        {
            get
            {
                return Processor * Memory;
            }
        }
       

    }
}
