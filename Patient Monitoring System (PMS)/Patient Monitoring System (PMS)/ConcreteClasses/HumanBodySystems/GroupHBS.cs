using Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;
using System.Collections.Generic;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems
{
    public class GroupHBS : HumanBodySystem
    {
        List<HumanBodySystem> humanBodySystems = new List<HumanBodySystem>();
        public double value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double lowerValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double upperValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool warningState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Observable observable;

        public string title { get; set; }

        public GroupHBS()
        {
            this.observable = new Observable(this);
        }

        public GroupHBS(HumanBodySystem initialHbs)
        {
            humanBodySystems.Add(initialHbs);
            this.observable = new Observable(this);
        }

        public void add(HumanBodySystem hbs)
        {
            humanBodySystems.Add(hbs);
        }
        public void showReading()
        {
            IEnumerator<HumanBodySystem> enumeration = humanBodySystems.GetEnumerator();
            while (enumeration.MoveNext())
            {
                HumanBodySystem hbs = (HumanBodySystem)enumeration.Current;
                hbs.showReading();
            }
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            IEnumerator<HumanBodySystem> enumeration = humanBodySystems.GetEnumerator();
            while (enumeration.MoveNext())
            {
                ReadingObservable hbs = (ReadingObservable)enumeration.Current;
                hbs.registerObserver(observer);
            }
            //observable.registerObserver(observer);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }
    }
}
