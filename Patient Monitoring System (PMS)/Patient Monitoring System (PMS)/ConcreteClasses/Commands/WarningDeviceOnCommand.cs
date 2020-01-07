using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.Commands
{
    public class WarningDeviceOnCommand : Command
    {
        WarningDevice warningDevice;

        public WarningDeviceOnCommand(WarningDevice warningDevice)
        {
            this.warningDevice = warningDevice;
        }

        public void execute()
        {
            warningDevice.warn();
        }
    }
}
