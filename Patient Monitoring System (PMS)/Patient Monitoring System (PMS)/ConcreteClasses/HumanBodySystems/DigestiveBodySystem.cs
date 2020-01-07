using Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems
{
    public class DigestiveBodySystem : HumanBodySystem
    {
        public Observable observable;
        public double value { get; set; }
        public double lowerValue { get; set; } = 40;
        public double upperValue { get; set; } = 60;
        public string title { get; } = "Digestive System";
        public bool warningState { get; set; } = false;
        public DigestiveBodySystem(double value)
        {
            this.value = value;
            observable = new Observable(this);
        }
        public void showReading()
        {
            string str = this.title + " Reading is " + this.value;
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
