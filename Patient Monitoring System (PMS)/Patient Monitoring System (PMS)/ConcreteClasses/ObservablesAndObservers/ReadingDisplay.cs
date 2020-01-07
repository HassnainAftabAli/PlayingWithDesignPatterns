using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers
{
    public class ReadingDisplay:Observer
    {
        public void update(ReadingObservable hbs)
        {
            HumanBodySystem thisHbs = (HumanBodySystem)hbs;
            string disp = (thisHbs.title.Equals("Cardiovascular System") || thisHbs.title.Equals("Respiratory System")) ? "\tDisplay: ":"Display: ";
            disp += "New Reading from " + thisHbs.title + ": " + thisHbs.value + "\n";
            Console.WriteLine(disp);
        }
    }
}
