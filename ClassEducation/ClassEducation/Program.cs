using System;

namespace ClassEducation
{
    class Program
    {
        static void Main(string [] args)
        {
            Server Docker = new Server("HPE-234", "ЦОД-1");
            Docker.Virtual = true;
            Docker.Memory = 2048;
            Docker.Processor = 8;
            

            
            Console.WriteLine(Docker.Model);
            Console.ReadLine();
        }
    }
}
