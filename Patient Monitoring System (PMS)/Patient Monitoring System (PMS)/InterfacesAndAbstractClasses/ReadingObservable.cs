namespace Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses
{
    public interface ReadingObservable
    {
        void registerObserver(Observer observer);
        void notifyObservers();
    }
}
