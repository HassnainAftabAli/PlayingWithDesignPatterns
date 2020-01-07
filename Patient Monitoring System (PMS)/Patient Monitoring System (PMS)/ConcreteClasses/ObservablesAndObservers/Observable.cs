using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers
{
    public class Observable : ReadingObservable
    {
        List<Observer> observers = new List<Observer>();
        ReadingObservable hbs;

        public Observable(ReadingObservable hbs)
        {
            this.hbs = hbs;
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            IEnumerator<Observer> enumeration = observers.GetEnumerator();
            while (enumeration.MoveNext())
            {
                Observer obs = (Observer)enumeration.Current;
                obs.update(hbs);
            }
        }

    }
}
