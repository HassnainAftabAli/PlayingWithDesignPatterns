using Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.Factories
{
    public class GeneralSensorFactory:AbstractSensorFactory
    {

        private static GeneralSensorFactory uniqueInstance;
        private GeneralSensorFactory() { }

        public static GeneralSensorFactory getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new GeneralSensorFactory();
            }

            return uniqueInstance;
        }

        public override HumanBodySystem createCBS(double value)
        {
            return new HBScounter(new CardiovasularBodySystem(value));
        }

        public override HumanBodySystem createDBS(double value)
        {
            return new HBScounter(new DigestiveBodySystem(value));
        }

        public override HumanBodySystem createIBS(double value)
        {
            return new HBScounter(new ImmuneBodySystem(value));
        }

        public override HumanBodySystem createNBS(double value)
        {
            return new HBScounter(new NervousBodySystem(value));
        }

        public override HumanBodySystem createRBS(double value)
        {
            return new HBScounter(new RespiratoryBodySystem(value));
        }

        public override HumanBodySystem createVBS(double value)
        {
            return new GroupHBS(new HBScounter(new VitalBodySystem(value)));
        }
    }
}