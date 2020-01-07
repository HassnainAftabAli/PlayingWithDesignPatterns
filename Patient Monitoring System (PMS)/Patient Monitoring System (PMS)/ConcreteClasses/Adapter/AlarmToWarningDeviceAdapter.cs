using Patient_Monitoring_System__PMS_.ConcreteClasses.Commands;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.Adapter
{
    public class AlarmToWarningDeviceAdapter : WarningDevice
    {
        Alarm alarm;

        public AlarmToWarningDeviceAdapter(Alarm alarm)
        {
            this.alarm = alarm;
        }

        public void warn()
        {
            alarm.on();
        }
    }
}
