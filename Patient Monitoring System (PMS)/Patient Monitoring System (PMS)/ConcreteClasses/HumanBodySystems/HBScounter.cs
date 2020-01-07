using Patient_Monitoring_System__PMS_.ConcreteClasses.Adapter;
using Patient_Monitoring_System__PMS_.ConcreteClasses.Commands;
using Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems
{
    public class HBScounter : HumanBodySystem
    {
        HumanBodySystem hbs;
        static int numberOfReadings;
        public double value { get; set; }
        public double lowerValue { get; set; }
        public double upperValue { get; set; }
        public bool warningState { get; set; } = false;

        Observable observable;

        Command command;

        public string title { get; set; }

        public HBScounter(HumanBodySystem hbs)
        {
            this.hbs = hbs;
            this.value = hbs.value;
            this.lowerValue = hbs.lowerValue;
            this.upperValue = hbs.upperValue;
            this.title = hbs.title;
            this.warningState = hbs.warningState;
            this.observable = new Observable(this);

            //Using adapter
            Alarm alarm = new Alarm();
            WarningDevice warningDevice = new AlarmToWarningDeviceAdapter(alarm);
            this.command = new WarningDeviceOnCommand(warningDevice);
        }

        public void showReading()
        {
            if (this.value < lowerValue || this.value > upperValue)
            {
                numberOfReadings++;
                hbs.warningState = true;
                alarmShouldInitiate();
            }

            hbs.showReading();
            notifyObservers();
        }

        public static int getNumberOfReadings()
        {
            return numberOfReadings;
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void alarmShouldInitiate()
        {
            command.execute();
        } 
    }
}
