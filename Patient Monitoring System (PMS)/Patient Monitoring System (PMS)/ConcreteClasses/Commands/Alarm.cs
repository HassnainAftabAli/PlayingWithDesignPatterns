using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.Commands
{
    public class Alarm
    {
        public void on()
        {
            Console.WriteLine("ALARM: WARNING WARNING");
        }

        public void off()
        {
            Console.WriteLine("Turning off alarm");
        }
    }
}
