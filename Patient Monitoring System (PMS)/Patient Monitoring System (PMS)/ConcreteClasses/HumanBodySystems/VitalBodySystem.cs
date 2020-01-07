using Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems
{
    public class VitalBodySystem : HumanBodySystem
    {
        public Observable observable;
        public double value { get; set; }
        public double lowerValue { get; set; } = 75;
        public double upperValue { get; set; } = 90;
        public string title { get; } = "Vital System";
        public bool warningState { get; set; } = false;

        public VitalBodySystem(double value)
        {
            this.value = value;
            this.observable = new Observable(this);
        }

        public void showReading()
        {
            string str = this.title + " Reading is " + this.value + " and the subsytem readings are:";
            if (warningState)
                str = str.ToUpper();
            Console.WriteLine(str);
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }
    }
}
