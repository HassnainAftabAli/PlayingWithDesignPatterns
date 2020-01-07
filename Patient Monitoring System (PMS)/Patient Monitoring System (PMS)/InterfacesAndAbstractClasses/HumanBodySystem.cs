namespace Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses
{
    public interface HumanBodySystem : ReadingObservable
    {
        string title { get; }
        double value { get; set; }
        double lowerValue { get; set; }
        double upperValue { get; set; }
        bool warningState { get; set; }
        void showReading();
    }
}
